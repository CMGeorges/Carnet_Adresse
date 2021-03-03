namespace Carnet_Adresse
{
    partial class CATP1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CATP1));
            this.listContact = new System.Windows.Forms.ListBox();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.panelFiche = new System.Windows.Forms.Panel();
            this.ZipBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.AddressBox2 = new System.Windows.Forms.TextBox();
            this.AddressBox1 = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.MiddleNBox = new System.Windows.Forms.TextBox();
            this.LastNBox = new System.Windows.Forms.TextBox();
            this.FirstNBox = new System.Windows.Forms.TextBox();
            this.lbl_Zip = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Address2 = new System.Windows.Forms.Label();
            this.lbl_Adress1 = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_MiddleN = new System.Windows.Forms.Label();
            this.lbl_FirstN = new System.Windows.Forms.Label();
            this.lbl_LastN = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlContact.SuspendLayout();
            this.panelFiche.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // listContact
            // 
            this.listContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContact.FormatString = "Contact.LastName, Contact.FirstName";
            this.listContact.FormattingEnabled = true;
            this.listContact.Location = new System.Drawing.Point(0, 0);
            this.listContact.Name = "listContact";
            this.listContact.ScrollAlwaysVisible = true;
            this.listContact.Size = new System.Drawing.Size(156, 251);
            this.listContact.Sorted = true;
            this.listContact.TabIndex = 0;
            this.listContact.SelectedIndexChanged += new System.EventHandler(this.listContact_SelectedIndexChanged);
            this.listContact.DoubleClick += new System.EventHandler(this.listContact_DoubleClick);
            // 
            // pnlContact
            // 
            this.pnlContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContact.Controls.Add(this.listContact);
            this.pnlContact.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlContact.Location = new System.Drawing.Point(1, 1);
            this.pnlContact.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(156, 251);
            this.pnlContact.TabIndex = 27;
            // 
            // panelFiche
            // 
            this.panelFiche.Controls.Add(this.ZipBox);
            this.panelFiche.Controls.Add(this.CountryBox);
            this.panelFiche.Controls.Add(this.StateBox);
            this.panelFiche.Controls.Add(this.CityBox);
            this.panelFiche.Controls.Add(this.AddressBox2);
            this.panelFiche.Controls.Add(this.AddressBox1);
            this.panelFiche.Controls.Add(this.EmailBox);
            this.panelFiche.Controls.Add(this.PhoneBox);
            this.panelFiche.Controls.Add(this.MiddleNBox);
            this.panelFiche.Controls.Add(this.LastNBox);
            this.panelFiche.Controls.Add(this.FirstNBox);
            this.panelFiche.Controls.Add(this.lbl_Zip);
            this.panelFiche.Controls.Add(this.lbl_Country);
            this.panelFiche.Controls.Add(this.lbl_State);
            this.panelFiche.Controls.Add(this.lbl_City);
            this.panelFiche.Controls.Add(this.lbl_Address2);
            this.panelFiche.Controls.Add(this.lbl_Adress1);
            this.panelFiche.Controls.Add(this.lbl_Email);
            this.panelFiche.Controls.Add(this.lbl_Phone);
            this.panelFiche.Controls.Add(this.lbl_MiddleN);
            this.panelFiche.Controls.Add(this.lbl_FirstN);
            this.panelFiche.Controls.Add(this.lbl_LastN);
            this.panelFiche.Location = new System.Drawing.Point(157, 1);
            this.panelFiche.Margin = new System.Windows.Forms.Padding(0);
            this.panelFiche.Name = "panelFiche";
            this.panelFiche.Size = new System.Drawing.Size(594, 251);
            this.panelFiche.TabIndex = 28;
            // 
            // ZipBox
            // 
            this.ZipBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ZipBox.Location = new System.Drawing.Point(356, 180);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(102, 20);
            this.ZipBox.TabIndex = 46;
            // 
            // CountryBox
            // 
            this.CountryBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CountryBox.Location = new System.Drawing.Point(80, 216);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(175, 20);
            this.CountryBox.TabIndex = 45;
            // 
            // StateBox
            // 
            this.StateBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StateBox.Location = new System.Drawing.Point(80, 180);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(175, 20);
            this.StateBox.TabIndex = 44;
            // 
            // CityBox
            // 
            this.CityBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CityBox.Location = new System.Drawing.Point(80, 148);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(175, 20);
            this.CityBox.TabIndex = 43;
            // 
            // AddressBox2
            // 
            this.AddressBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddressBox2.Location = new System.Drawing.Point(80, 116);
            this.AddressBox2.Name = "AddressBox2";
            this.AddressBox2.Size = new System.Drawing.Size(175, 20);
            this.AddressBox2.TabIndex = 42;
            // 
            // AddressBox1
            // 
            this.AddressBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddressBox1.Location = new System.Drawing.Point(80, 83);
            this.AddressBox1.Name = "AddressBox1";
            this.AddressBox1.Size = new System.Drawing.Size(175, 20);
            this.AddressBox1.TabIndex = 41;
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmailBox.Location = new System.Drawing.Point(261, 47);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(207, 20);
            this.EmailBox.TabIndex = 40;
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PhoneBox.Location = new System.Drawing.Point(80, 47);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(102, 20);
            this.PhoneBox.TabIndex = 39;
            // 
            // MiddleNBox
            // 
            this.MiddleNBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MiddleNBox.Location = new System.Drawing.Point(455, 13);
            this.MiddleNBox.Name = "MiddleNBox";
            this.MiddleNBox.Size = new System.Drawing.Size(102, 20);
            this.MiddleNBox.TabIndex = 38;
            // 
            // LastNBox
            // 
            this.LastNBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LastNBox.Location = new System.Drawing.Point(80, 13);
            this.LastNBox.Name = "LastNBox";
            this.LastNBox.Size = new System.Drawing.Size(102, 20);
            this.LastNBox.TabIndex = 37;
            // 
            // FirstNBox
            // 
            this.FirstNBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstNBox.Location = new System.Drawing.Point(261, 13);
            this.FirstNBox.Name = "FirstNBox";
            this.FirstNBox.Size = new System.Drawing.Size(102, 20);
            this.FirstNBox.TabIndex = 36;
            // 
            // lbl_Zip
            // 
            this.lbl_Zip.AutoSize = true;
            this.lbl_Zip.Location = new System.Drawing.Point(323, 183);
            this.lbl_Zip.Name = "lbl_Zip";
            this.lbl_Zip.Size = new System.Drawing.Size(27, 13);
            this.lbl_Zip.TabIndex = 35;
            this.lbl_Zip.Text = "ZIP";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(20, 223);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(50, 13);
            this.lbl_Country.TabIndex = 34;
            this.lbl_Country.Text = "Country";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(33, 187);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(37, 13);
            this.lbl_State.TabIndex = 33;
            this.lbl_State.Text = "State";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(42, 151);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(28, 13);
            this.lbl_City.TabIndex = 32;
            this.lbl_City.Text = "City";
            // 
            // lbl_Address2
            // 
            this.lbl_Address2.AutoSize = true;
            this.lbl_Address2.Location = new System.Drawing.Point(7, 123);
            this.lbl_Address2.Name = "lbl_Address2";
            this.lbl_Address2.Size = new System.Drawing.Size(63, 13);
            this.lbl_Address2.TabIndex = 31;
            this.lbl_Address2.Text = "Address 2";
            // 
            // lbl_Adress1
            // 
            this.lbl_Adress1.AutoSize = true;
            this.lbl_Adress1.Location = new System.Drawing.Point(7, 90);
            this.lbl_Adress1.Name = "lbl_Adress1";
            this.lbl_Adress1.Size = new System.Drawing.Size(63, 13);
            this.lbl_Adress1.TabIndex = 30;
            this.lbl_Adress1.Text = "Address 1";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(218, 54);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(37, 13);
            this.lbl_Email.TabIndex = 29;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(31, 54);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(43, 13);
            this.lbl_Phone.TabIndex = 28;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_MiddleN
            // 
            this.lbl_MiddleN.AutoSize = true;
            this.lbl_MiddleN.Location = new System.Drawing.Point(369, 20);
            this.lbl_MiddleN.Name = "lbl_MiddleN";
            this.lbl_MiddleN.Size = new System.Drawing.Size(80, 13);
            this.lbl_MiddleN.TabIndex = 27;
            this.lbl_MiddleN.Text = "Middle Name";
            // 
            // lbl_FirstN
            // 
            this.lbl_FirstN.AutoSize = true;
            this.lbl_FirstN.Location = new System.Drawing.Point(188, 20);
            this.lbl_FirstN.Name = "lbl_FirstN";
            this.lbl_FirstN.Size = new System.Drawing.Size(67, 13);
            this.lbl_FirstN.TabIndex = 26;
            this.lbl_FirstN.Text = "First Name";
            // 
            // lbl_LastN
            // 
            this.lbl_LastN.AutoSize = true;
            this.lbl_LastN.Location = new System.Drawing.Point(7, 20);
            this.lbl_LastN.Name = "lbl_LastN";
            this.lbl_LastN.Size = new System.Drawing.Size(67, 13);
            this.lbl_LastN.TabIndex = 25;
            this.lbl_LastN.Text = "Last Name";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Controls.Add(this.btnEdit);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 252);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(728, 44);
            this.pnlButton.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.BorderSize = 5;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(581, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 44);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 5;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(436, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 44);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.FlatAppearance.BorderSize = 5;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(291, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 44);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(146, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 44);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNew.FlatAppearance.BorderSize = 5;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(1, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(145, 44);
            this.btnNew.TabIndex = 33;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // CATP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(728, 296);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.panelFiche);
            this.Controls.Add(this.pnlContact);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CATP1";
            this.Text = "Address Book Demo";
            this.pnlContact.ResumeLayout(false);
            this.panelFiche.ResumeLayout(false);
            this.panelFiche.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listContact;
        private System.Windows.Forms.Panel pnlContact;
        private System.Windows.Forms.Panel panelFiche;
        private System.Windows.Forms.TextBox ZipBox;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox AddressBox2;
        private System.Windows.Forms.TextBox AddressBox1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox MiddleNBox;
        private System.Windows.Forms.TextBox LastNBox;
        private System.Windows.Forms.TextBox FirstNBox;
        private System.Windows.Forms.Label lbl_Zip;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Address2;
        private System.Windows.Forms.Label lbl_Adress1;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_MiddleN;
        private System.Windows.Forms.Label lbl_FirstN;
        private System.Windows.Forms.Label lbl_LastN;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
    }
}

