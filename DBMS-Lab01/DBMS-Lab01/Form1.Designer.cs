namespace DBMS_Lab01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.labelDoctors = new System.Windows.Forms.Label();
            this.labelRequests = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelCNP = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelRH = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelDoctorId = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBirthDate = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbBloodGroup = new System.Windows.Forms.TextBox();
            this.tbRH = new System.Windows.Forms.TextBox();
            this.tbDoctorID = new System.Windows.Forms.TextBox();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.btnUpdateRequest = new System.Windows.Forms.Button();
            this.viewDoctors = new System.Windows.Forms.DataGridView();
            this.viewRequests = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.viewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctor.Location = new System.Drawing.Point(300, 338);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(140, 27);
            this.btnAddDoctor.TabIndex = 0;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // labelDoctors
            // 
            this.labelDoctors.AutoSize = true;
            this.labelDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctors.Location = new System.Drawing.Point(12, 9);
            this.labelDoctors.Name = "labelDoctors";
            this.labelDoctors.Size = new System.Drawing.Size(100, 25);
            this.labelDoctors.TabIndex = 2;
            this.labelDoctors.Text = "Doctors:";
            // 
            // labelRequests
            // 
            this.labelRequests.AutoSize = true;
            this.labelRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequests.Location = new System.Drawing.Point(484, 9);
            this.labelRequests.Name = "labelRequests";
            this.labelRequests.Size = new System.Drawing.Size(118, 25);
            this.labelRequests.TabIndex = 4;
            this.labelRequests.Text = "Requests:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 340);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(13, 408);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(101, 20);
            this.labelDateOfBirth.TabIndex = 6;
            this.labelDateOfBirth.Text = "Date of birth:";
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNP.Location = new System.Drawing.Point(13, 375);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(45, 20);
            this.labelCNP.TabIndex = 7;
            this.labelCNP.Text = "CNP:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(485, 340);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(72, 20);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelRH
            // 
            this.labelRH.AutoSize = true;
            this.labelRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRH.Location = new System.Drawing.Point(485, 375);
            this.labelRH.Name = "labelRH";
            this.labelRH.Size = new System.Drawing.Size(37, 20);
            this.labelRH.TabIndex = 9;
            this.labelRH.Text = "RH:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(485, 411);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(99, 20);
            this.labelGroup.TabIndex = 10;
            this.labelGroup.Text = "Blood group:";
            // 
            // labelDoctorId
            // 
            this.labelDoctorId.AutoSize = true;
            this.labelDoctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorId.Location = new System.Drawing.Point(485, 443);
            this.labelDoctorId.Name = "labelDoctorId";
            this.labelDoctorId.Size = new System.Drawing.Size(82, 20);
            this.labelDoctorId.TabIndex = 11;
            this.labelDoctorId.Text = "Doctor ID:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(129, 337);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 26);
            this.tbName.TabIndex = 13;
            // 
            // tbBirthDate
            // 
            this.tbBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBirthDate.Location = new System.Drawing.Point(129, 401);
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.Size = new System.Drawing.Size(100, 26);
            this.tbBirthDate.TabIndex = 14;
            // 
            // tbCNP
            // 
            this.tbCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCNP.Location = new System.Drawing.Point(129, 369);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(100, 26);
            this.tbCNP.TabIndex = 15;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(610, 334);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 26);
            this.tbQuantity.TabIndex = 16;
            // 
            // tbBloodGroup
            // 
            this.tbBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBloodGroup.Location = new System.Drawing.Point(610, 405);
            this.tbBloodGroup.Name = "tbBloodGroup";
            this.tbBloodGroup.Size = new System.Drawing.Size(100, 26);
            this.tbBloodGroup.TabIndex = 17;
            // 
            // tbRH
            // 
            this.tbRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRH.Location = new System.Drawing.Point(610, 369);
            this.tbRH.Name = "tbRH";
            this.tbRH.Size = new System.Drawing.Size(100, 26);
            this.tbRH.TabIndex = 18;
            // 
            // tbDoctorID
            // 
            this.tbDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorID.Location = new System.Drawing.Point(610, 437);
            this.tbDoctorID.Name = "tbDoctorID";
            this.tbDoctorID.Size = new System.Drawing.Size(100, 26);
            this.tbDoctorID.TabIndex = 19;
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequest.Location = new System.Drawing.Point(771, 337);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(141, 29);
            this.btnAddRequest.TabIndex = 20;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRequest.Location = new System.Drawing.Point(771, 386);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(141, 29);
            this.btnDeleteRequest.TabIndex = 21;
            this.btnDeleteRequest.Text = "Delete Request";
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            this.btnDeleteRequest.Click += new System.EventHandler(this.btnDeleteRequest_Click);
            // 
            // btnUpdateRequest
            // 
            this.btnUpdateRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRequest.Location = new System.Drawing.Point(771, 434);
            this.btnUpdateRequest.Name = "btnUpdateRequest";
            this.btnUpdateRequest.Size = new System.Drawing.Size(141, 29);
            this.btnUpdateRequest.TabIndex = 22;
            this.btnUpdateRequest.Text = "Update Request";
            this.btnUpdateRequest.UseVisualStyleBackColor = true;
            this.btnUpdateRequest.Click += new System.EventHandler(this.btnUpdateRequest_Click);
            // 
            // viewDoctors
            // 
            this.viewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDoctors.Location = new System.Drawing.Point(17, 37);
            this.viewDoctors.Name = "viewDoctors";
            this.viewDoctors.Size = new System.Drawing.Size(423, 270);
            this.viewDoctors.TabIndex = 23;
            this.viewDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewDoctors_CellClick);
            // 
            // viewRequests
            // 
            this.viewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewRequests.Location = new System.Drawing.Point(489, 37);
            this.viewRequests.Name = "viewRequests";
            this.viewRequests.Size = new System.Drawing.Size(423, 270);
            this.viewRequests.TabIndex = 24;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(129, 433);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(311, 22);
            this.dateTimePicker.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 545);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.viewRequests);
            this.Controls.Add(this.viewDoctors);
            this.Controls.Add(this.btnUpdateRequest);
            this.Controls.Add(this.btnDeleteRequest);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.tbDoctorID);
            this.Controls.Add(this.tbRH);
            this.Controls.Add(this.tbBloodGroup);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbBirthDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelDoctorId);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelRH);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRequests);
            this.Controls.Add(this.labelDoctors);
            this.Controls.Add(this.btnAddDoctor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Label labelDoctors;
        private System.Windows.Forms.Label labelRequests;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelRH;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelDoctorId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBirthDate;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbBloodGroup;
        private System.Windows.Forms.TextBox tbRH;
        private System.Windows.Forms.TextBox tbDoctorID;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Button btnUpdateRequest;
        private System.Windows.Forms.DataGridView viewDoctors;
        private System.Windows.Forms.DataGridView viewRequests;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

