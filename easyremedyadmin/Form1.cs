using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace easyremedyadmin
{
    public enum onAction
    {
        None,
        Create,
        Update,
        Delete,
        Deactivate
    }

    public partial class Main : Form
    {
        MySqlConnection conn = null;
        onAction actAction = onAction.None;
        int iSelected = 0, iSID = -1;

        public Main()
        {
            InitializeComponent();
            UpdateUsers();
        }


        /// <summary>
        /// Perfroms an update in the DGV
        /// </summary>
        void UpdateUsers()
        {
            dgvUsers.DataSource = LoadUsers();
        }

        /// <summary>
        /// Creates a new conection to the sql server
        /// </summary>
        void CreateConection ()
        {
            string connData = string.Format("server={0};user=copenlabscom_aplications;database=copenlabscom_easyremedy;port=3306;password=rootaplications;SslMode=None", false ? "localhost" : "copenlabs.com");

            try
            {
                if (conn == null)
                {
                    conn = new MySqlConnection(connData);
                }
                else
                {
                    conn.Open();
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show("An error ocurred while connecting to the DB");
                return;
            }
        }

        /// <summary>
        /// Close the existing conection
        /// </summary>
        void CloseConection ()
        {
            if(conn == null)
            {
                return;
            }

            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error ocurred while closing the conection to the DB. \nPlease, restar the program.");
                return;
            }
        }

        /// <summary>
        /// Load all the users in the DB
        /// </summary>
        DataTable LoadUsers()
        {
            DataTable result = new DataTable();

            try
            {
                CreateConection();
            }
            catch(Exception e)
            {
                MessageBox.Show("Conection to DB not OPEN");
                return null;
            }

            try
            {
                string query = "Select * From users";
                MySqlDataAdapter dap = new MySqlDataAdapter(query, conn);
                dap.Fill(result);

            }
            catch(Exception e)
            {
                MessageBox.Show("An error ocurred during the operation, try again\n\n" + e.ToString(), "Load Users");
                CloseConection();
                return null;
            }

            CloseConection();

            return result;
        }

        void createAction (object o, EventArgs e)
        {
            SelectAction(onAction.Create);
        }

        void updateAction(object o, EventArgs e)
        {
            if (dgvUsers.CurrentCell == null)
            {
                MessageBox.Show("Must select one user first", "Missing Selection");
                return;
            }

            iSelected = dgvUsers.CurrentCell.RowIndex;

            iSID = (int)dgvUsers.Rows[iSelected].Cells[0].Value;
            txtMail.Text = (string)dgvUsers.Rows[iSelected].Cells[1].Value;
            txtPass.Text = (string)dgvUsers.Rows[iSelected].Cells[2].Value;
            dpExpire.Value = (DateTime)dgvUsers.Rows[iSelected].Cells[3].Value;
            txtKey.Text = (string)dgvUsers.Rows[iSelected].Cells[4].Value;

            SelectAction(onAction.Update);
        }

        void deletedAction(object o, EventArgs e)
        {
            if(dgvUsers.CurrentCell == null)
            {
                MessageBox.Show("Must select one user first", "Missing Selection");
                return;
            }

            iSelected = dgvUsers.CurrentCell.RowIndex;

            iSID = (int)dgvUsers.Rows[iSelected].Cells[0].Value;
            txtMail.Text = (string)dgvUsers.Rows[iSelected].Cells[1].Value;
            txtPass.Text = (string)dgvUsers.Rows[iSelected].Cells[2].Value;
            dpExpire.Value = (DateTime)dgvUsers.Rows[iSelected].Cells[3].Value;
            txtKey.Text = (string)dgvUsers.Rows[iSelected].Cells[4].Value;

            SelectAction(onAction.Deactivate);
        }

        void aceptAction(object o, EventArgs e)
        {
            switch (actAction)
            {
                case onAction.Create:
                    CreateUser();
                    break;
                case onAction.Update:
                    UpdateUser();
                    break;
                case onAction.Deactivate:
                    DeactivateUser();
                    break;
            }

        }

        void cancelAction(object o, EventArgs e)
        {
            cleanInputs();
        }

        /// <summary>
        /// General cleanign action
        /// </summary>
        void cleanInputs()
        {
            actAction = onAction.None;

            pnlActions.Enabled = true;
            pnlInput.Enabled = false;

            txtMail.Text = txtPass.Text = txtKey.Text = "";
            dpExpire.Value = DateTime.Today;
            iSelected = 0;
            iSID = -1;
        }

        /// <summary>
        /// Filters some shit before actions
        /// </summary>
        /// <param name="selection">Selected Action</param>
        void SelectAction(onAction selection)
        {
            actAction = selection;
            pnlActions.Enabled = false;

            switch (actAction)
            {
                case onAction.Create:
                    pnlInput.Enabled = true;
                    Guid key = Guid.NewGuid();
                    txtKey.Text = key.ToString();
                    break;
                case onAction.Update:
                    pnlInput.Enabled = true;
                    break;
                case onAction.Deactivate:
                    pnlInput.Enabled = false;
                    DialogResult dr = MessageBox.Show("Do you want to Deactivate the selected user?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        aceptAction(null, null);
                    }
                    else
                    {
                        cancelAction(null, null);
                    }
                    break;
            }

        }

        /// <summary>
        /// Insert new user into DB
        /// </summary>
        void CreateUser()
        {
            CreateConection();

            try
            {
                string sql = string.Format("Insert Into users Values(0, '{0}', '{1}', '{2}', '{3}', 1, 0)", txtMail.Text, txtPass.Text, dpExpire.Value.Date.ToString("yyyy-MM-dd"), txtKey.Text);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("An error ocurred during the operation, try again", "Create User");
                return;
            }

            MessageBox.Show("User created successfully", "Create User");

            CloseConection();

            cleanInputs();
            UpdateUsers();
        }

        void UpdateUser()
        {
            if(iSID < 0)
            {
                MessageBox.Show("An error ocurred during the operation, try again", "Update User - Selected User");
                return;
            }

            CreateConection();

            try
            {
                string sql = string.Format("Update users Set email='{0}', pass='{1}', expires='{2}', signature='{3}', active=1 Where id={4}", txtMail.Text, txtPass.Text, dpExpire.Value.Date.ToString("yyyy-MM-dd"), txtKey.Text, iSID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error ocurred during the operation, try again", "Update User - Query");
                CloseConection();
                return;
            }

            CloseConection();

            cleanInputs();
            UpdateUsers();
        }

        void DeactivateUser()
        {
            if (iSID < 0)
            {
                MessageBox.Show("An error ocurred during the operation, try again", "Deactivate User - Selected User");
                return;
            }

            CreateConection();

            try
            {
                string sql = string.Format("Update users Set active=0 Where id={0}", iSID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error ocurred during the operation, try again", "Deactivate User - Query");
                CloseConection();
                return;
            }

            CloseConection();

            cleanInputs();
            UpdateUsers();
        }
    }
}
