
namespace easyremedyadmin
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dpExpire = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 195);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1155, 493);
            this.dgvUsers.TabIndex = 0;
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(38, 122);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(222, 22);
            this.btnDeactivate.TabIndex = 1;
            this.btnDeactivate.Text = "DEACTIVATE";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.deletedAction);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(38, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(222, 22);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.updateAction);
            // 
            // pnlInput
            // 
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.btnCancel);
            this.pnlInput.Controls.Add(this.btnFinish);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.dpExpire);
            this.pnlInput.Controls.Add(this.label3);
            this.pnlInput.Controls.Add(this.txtKey);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Controls.Add(this.txtPass);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.txtMail);
            this.pnlInput.Enabled = false;
            this.pnlInput.Location = new System.Drawing.Point(12, 32);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(870, 144);
            this.pnlInput.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(686, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelAction);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(686, 74);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(168, 23);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Accept";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.aceptAction);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Access Expiration";
            // 
            // dpExpire
            // 
            this.dpExpire.CustomFormat = "yyyy-MM-dd";
            this.dpExpire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpExpire.Location = new System.Drawing.Point(6, 67);
            this.dpExpire.Name = "dpExpire";
            this.dpExpire.Size = new System.Drawing.Size(381, 20);
            this.dpExpire.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generated Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(6, 106);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(381, 20);
            this.txtKey.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(393, 25);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(322, 20);
            this.txtPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(6, 25);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(381, 20);
            this.txtMail.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(38, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(222, 57);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.createAction);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "User Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Selected User";
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnCreate);
            this.pnlActions.Controls.Add(this.label6);
            this.pnlActions.Controls.Add(this.btnDeactivate);
            this.pnlActions.Controls.Add(this.btnUpdate);
            this.pnlActions.Location = new System.Drawing.Point(888, 32);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(279, 144);
            this.pnlActions.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 700);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.dgvUsers);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1195, 739);
            this.MinimumSize = new System.Drawing.Size(1195, 739);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Remedy - Administration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpExpire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlActions;
    }
}

