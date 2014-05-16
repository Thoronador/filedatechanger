namespace FileDateChanger
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAccess = new System.Windows.Forms.DateTimePicker();
            this.lblCreatedCaption = new System.Windows.Forms.Label();
            this.lblModifiedCaption = new System.Windows.Forms.Label();
            this.lblAccessCaption = new System.Windows.Forms.Label();
            this.btnChangeCreated = new System.Windows.Forms.Button();
            this.btnChangeModified = new System.Windows.Forms.Button();
            this.btnChangeAccess = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.lblCaptionFileName = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblCreatedData = new System.Windows.Forms.Label();
            this.lblModifiedData = new System.Windows.Forms.Label();
            this.lblAccessData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerCreated.CustomFormat = "dddd, dd. MMMM yyyy, HH:mm:ss";
            this.dateTimePickerCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCreated.Location = new System.Drawing.Point(31, 92);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(272, 20);
            this.dateTimePickerCreated.TabIndex = 0;
            this.dateTimePickerCreated.ValueChanged += new System.EventHandler(this.dateTimePickerCreated_ValueChanged);
            // 
            // dateTimePickerModified
            // 
            this.dateTimePickerModified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerModified.CustomFormat = "dddd, dd. MMMM yyyy, HH:mm:ss";
            this.dateTimePickerModified.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerModified.Location = new System.Drawing.Point(31, 156);
            this.dateTimePickerModified.Name = "dateTimePickerModified";
            this.dateTimePickerModified.Size = new System.Drawing.Size(272, 20);
            this.dateTimePickerModified.TabIndex = 1;
            this.dateTimePickerModified.ValueChanged += new System.EventHandler(this.dateTimePickerModified_ValueChanged);
            // 
            // dateTimePickerAccess
            // 
            this.dateTimePickerAccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerAccess.CustomFormat = "dddd, dd. MMMM yyyy, HH:mm:ss";
            this.dateTimePickerAccess.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAccess.Location = new System.Drawing.Point(31, 217);
            this.dateTimePickerAccess.Name = "dateTimePickerAccess";
            this.dateTimePickerAccess.Size = new System.Drawing.Size(272, 20);
            this.dateTimePickerAccess.TabIndex = 2;
            this.dateTimePickerAccess.ValueChanged += new System.EventHandler(this.dateTimePickerAccess_ValueChanged);
            // 
            // lblCreatedCaption
            // 
            this.lblCreatedCaption.AutoSize = true;
            this.lblCreatedCaption.Location = new System.Drawing.Point(12, 67);
            this.lblCreatedCaption.Name = "lblCreatedCaption";
            this.lblCreatedCaption.Size = new System.Drawing.Size(41, 13);
            this.lblCreatedCaption.TabIndex = 3;
            this.lblCreatedCaption.Text = "Erstellt:";
            // 
            // lblModifiedCaption
            // 
            this.lblModifiedCaption.AutoSize = true;
            this.lblModifiedCaption.Location = new System.Drawing.Point(12, 129);
            this.lblModifiedCaption.Name = "lblModifiedCaption";
            this.lblModifiedCaption.Size = new System.Drawing.Size(54, 13);
            this.lblModifiedCaption.TabIndex = 4;
            this.lblModifiedCaption.Text = "Geändert:";
            // 
            // lblAccessCaption
            // 
            this.lblAccessCaption.AutoSize = true;
            this.lblAccessCaption.Location = new System.Drawing.Point(12, 191);
            this.lblAccessCaption.Name = "lblAccessCaption";
            this.lblAccessCaption.Size = new System.Drawing.Size(75, 13);
            this.lblAccessCaption.TabIndex = 5;
            this.lblAccessCaption.Text = "Letzter Zugriff:";
            // 
            // btnChangeCreated
            // 
            this.btnChangeCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeCreated.Location = new System.Drawing.Point(309, 92);
            this.btnChangeCreated.Name = "btnChangeCreated";
            this.btnChangeCreated.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCreated.TabIndex = 6;
            this.btnChangeCreated.Text = "Ändern";
            this.btnChangeCreated.UseVisualStyleBackColor = true;
            this.btnChangeCreated.Click += new System.EventHandler(this.btnChangeCreated_Click);
            // 
            // btnChangeModified
            // 
            this.btnChangeModified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeModified.Location = new System.Drawing.Point(309, 156);
            this.btnChangeModified.Name = "btnChangeModified";
            this.btnChangeModified.Size = new System.Drawing.Size(75, 23);
            this.btnChangeModified.TabIndex = 7;
            this.btnChangeModified.Text = "Ändern";
            this.btnChangeModified.UseVisualStyleBackColor = true;
            this.btnChangeModified.Click += new System.EventHandler(this.btnChangeModified_Click);
            // 
            // btnChangeAccess
            // 
            this.btnChangeAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeAccess.Location = new System.Drawing.Point(309, 214);
            this.btnChangeAccess.Name = "btnChangeAccess";
            this.btnChangeAccess.Size = new System.Drawing.Size(75, 23);
            this.btnChangeAccess.TabIndex = 8;
            this.btnChangeAccess.Text = "Ändern";
            this.btnChangeAccess.UseVisualStyleBackColor = true;
            this.btnChangeAccess.Click += new System.EventHandler(this.btnChangeAccess_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "Alle Dateien|*.*";
            this.ofdFile.Title = "Zu ändernde Datei wählen...";
            // 
            // lblCaptionFileName
            // 
            this.lblCaptionFileName.AutoSize = true;
            this.lblCaptionFileName.Location = new System.Drawing.Point(12, 9);
            this.lblCaptionFileName.Name = "lblCaptionFileName";
            this.lblCaptionFileName.Size = new System.Drawing.Size(35, 13);
            this.lblCaptionFileName.TabIndex = 9;
            this.lblCaptionFileName.Text = "Datei:";
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.AutoEllipsis = true;
            this.lblFileName.Location = new System.Drawing.Point(54, 32);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(343, 13);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.Text = "noch keine Datei gewählt";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(15, 27);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 23);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblCreatedData
            // 
            this.lblCreatedData.AutoSize = true;
            this.lblCreatedData.Location = new System.Drawing.Point(121, 67);
            this.lblCreatedData.Name = "lblCreatedData";
            this.lblCreatedData.Size = new System.Drawing.Size(58, 13);
            this.lblCreatedData.TabIndex = 12;
            this.lblCreatedData.Text = "unbekannt";
            // 
            // lblModifiedData
            // 
            this.lblModifiedData.AutoSize = true;
            this.lblModifiedData.Location = new System.Drawing.Point(121, 129);
            this.lblModifiedData.Name = "lblModifiedData";
            this.lblModifiedData.Size = new System.Drawing.Size(58, 13);
            this.lblModifiedData.TabIndex = 13;
            this.lblModifiedData.Text = "unbekannt";
            // 
            // lblAccessData
            // 
            this.lblAccessData.AutoSize = true;
            this.lblAccessData.Location = new System.Drawing.Point(121, 191);
            this.lblAccessData.Name = "lblAccessData";
            this.lblAccessData.Size = new System.Drawing.Size(58, 13);
            this.lblAccessData.TabIndex = 14;
            this.lblAccessData.Text = "unbekannt";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 273);
            this.Controls.Add(this.lblAccessData);
            this.Controls.Add(this.lblModifiedData);
            this.Controls.Add(this.lblCreatedData);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblCaptionFileName);
            this.Controls.Add(this.btnChangeAccess);
            this.Controls.Add(this.btnChangeModified);
            this.Controls.Add(this.btnChangeCreated);
            this.Controls.Add(this.lblAccessCaption);
            this.Controls.Add(this.lblModifiedCaption);
            this.Controls.Add(this.lblCreatedCaption);
            this.Controls.Add(this.dateTimePickerAccess);
            this.Controls.Add(this.dateTimePickerModified);
            this.Controls.Add(this.dateTimePickerCreated);
            this.MinimumSize = new System.Drawing.Size(417, 300);
            this.Name = "FormMain";
            this.Text = "Dateidatum ändern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.DateTimePicker dateTimePickerModified;
        private System.Windows.Forms.DateTimePicker dateTimePickerAccess;
        private System.Windows.Forms.Label lblCreatedCaption;
        private System.Windows.Forms.Label lblModifiedCaption;
        private System.Windows.Forms.Label lblAccessCaption;
        private System.Windows.Forms.Button btnChangeCreated;
        private System.Windows.Forms.Button btnChangeModified;
        private System.Windows.Forms.Button btnChangeAccess;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Label lblCaptionFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblCreatedData;
        private System.Windows.Forms.Label lblModifiedData;
        private System.Windows.Forms.Label lblAccessData;
    }
}

