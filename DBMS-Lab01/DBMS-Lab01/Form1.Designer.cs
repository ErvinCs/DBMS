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
            this.viewDoctors = new System.Windows.Forms.ListView();
            this.labelDoctors = new System.Windows.Forms.Label();
            this.viewRequests = new System.Windows.Forms.ListView();
            this.labelRequests = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelRH = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelDoctorId = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBirthDate = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.btnUpdateRequest = new System.Windows.Forms.Button();
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
            // 
            // viewDoctors
            // 
            this.viewDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDoctors.Location = new System.Drawing.Point(17, 37);
            this.viewDoctors.Name = "viewDoctors";
            this.viewDoctors.Size = new System.Drawing.Size(423, 270);
            this.viewDoctors.TabIndex = 1;
            this.viewDoctors.UseCompatibleStateImageBehavior = false;
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
            this.labelDoctors.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewRequests
            // 
            this.viewRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRequests.Location = new System.Drawing.Point(489, 37);
            this.viewRequests.Name = "viewRequests";
            this.viewRequests.Size = new System.Drawing.Size(423, 270);
            this.viewRequests.TabIndex = 3;
            this.viewRequests.UseCompatibleStateImageBehavior = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "CNP:";
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
            this.labelQuantity.Click += new System.EventHandler(this.label6_Click);
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
            this.tbBirthDate.Location = new System.Drawing.Point(129, 372);
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.Size = new System.Drawing.Size(100, 26);
            this.tbBirthDate.TabIndex = 14;
            // 
            // tbCNP
            // 
            this.tbCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCNP.Location = new System.Drawing.Point(129, 408);
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
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(610, 405);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(610, 369);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(610, 437);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 19;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 545);
            this.Controls.Add(this.btnUpdateRequest);
            this.Controls.Add(this.btnDeleteRequest);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbBirthDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelDoctorId);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelRH);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRequests);
            this.Controls.Add(this.viewRequests);
            this.Controls.Add(this.labelDoctors);
            this.Controls.Add(this.viewDoctors);
            this.Controls.Add(this.btnAddDoctor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.ListView viewDoctors;
        private System.Windows.Forms.Label labelDoctors;
        private System.Windows.Forms.ListView viewRequests;
        private System.Windows.Forms.Label labelRequests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelRH;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelDoctorId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBirthDate;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Button btnUpdateRequest;
    }
}

