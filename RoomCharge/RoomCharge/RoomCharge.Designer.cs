
namespace Exercise3Exam1
{
    partial class RoomChargeCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.grpRoomInformation = new System.Windows.Forms.GroupBox();
            this.txtNightCharge = new System.Windows.Forms.TextBox();
            this.lblNightCharge = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.lblNights = new System.Windows.Forms.Label();
            this.grpAdditionalCharges = new System.Windows.Forms.GroupBox();
            this.txtMiscellaneous = new System.Windows.Forms.TextBox();
            this.lblMiscellaneous = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtRoomService = new System.Windows.Forms.TextBox();
            this.lblRoomService = new System.Windows.Forms.Label();
            this.grpTotalCharges = new System.Windows.Forms.GroupBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtAdditionalCharges = new System.Windows.Forms.TextBox();
            this.lblAdditionalCharges = new System.Windows.Forms.Label();
            this.txtRoomCharges = new System.Windows.Forms.TextBox();
            this.lblRoomCharges = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpRoomInformation.SuspendLayout();
            this.grpAdditionalCharges.SuspendLayout();
            this.grpTotalCharges.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(177, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Highlander Hotel";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(177, 74);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentDate.Location = new System.Drawing.Point(253, 78);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(28, 16);
            this.lblCurrentDate.TabIndex = 2;
            this.lblCurrentDate.Text = "xxx";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(177, 111);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentTime.Location = new System.Drawing.Point(253, 114);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(28, 16);
            this.lblCurrentTime.TabIndex = 4;
            this.lblCurrentTime.Text = "xxx";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpRoomInformation
            // 
            this.grpRoomInformation.Controls.Add(this.txtNightCharge);
            this.grpRoomInformation.Controls.Add(this.lblNightCharge);
            this.grpRoomInformation.Controls.Add(this.txtNights);
            this.grpRoomInformation.Controls.Add(this.lblNights);
            this.grpRoomInformation.Location = new System.Drawing.Point(12, 145);
            this.grpRoomInformation.Name = "grpRoomInformation";
            this.grpRoomInformation.Size = new System.Drawing.Size(239, 95);
            this.grpRoomInformation.TabIndex = 0;
            this.grpRoomInformation.TabStop = false;
            this.grpRoomInformation.Text = "Room Information";
            // 
            // txtNightCharge
            // 
            this.txtNightCharge.Location = new System.Drawing.Point(131, 55);
            this.txtNightCharge.Name = "txtNightCharge";
            this.txtNightCharge.Size = new System.Drawing.Size(79, 27);
            this.txtNightCharge.TabIndex = 3;
            // 
            // lblNightCharge
            // 
            this.lblNightCharge.AutoSize = true;
            this.lblNightCharge.Location = new System.Drawing.Point(9, 58);
            this.lblNightCharge.Name = "lblNightCharge";
            this.lblNightCharge.Size = new System.Drawing.Size(98, 20);
            this.lblNightCharge.TabIndex = 2;
            this.lblNightCharge.Text = "Night &charge:";
            this.lblNightCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(131, 24);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(79, 27);
            this.txtNights.TabIndex = 1;
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(52, 27);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(55, 20);
            this.lblNights.TabIndex = 0;
            this.lblNights.Text = "&Nights:";
            this.lblNights.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpAdditionalCharges
            // 
            this.grpAdditionalCharges.Controls.Add(this.txtMiscellaneous);
            this.grpAdditionalCharges.Controls.Add(this.lblMiscellaneous);
            this.grpAdditionalCharges.Controls.Add(this.txtTelephone);
            this.grpAdditionalCharges.Controls.Add(this.lblTelephone);
            this.grpAdditionalCharges.Controls.Add(this.txtRoomService);
            this.grpAdditionalCharges.Controls.Add(this.lblRoomService);
            this.grpAdditionalCharges.Location = new System.Drawing.Point(270, 145);
            this.grpAdditionalCharges.Name = "grpAdditionalCharges";
            this.grpAdditionalCharges.Size = new System.Drawing.Size(218, 122);
            this.grpAdditionalCharges.TabIndex = 1;
            this.grpAdditionalCharges.TabStop = false;
            this.grpAdditionalCharges.Text = "Additional Charges";
            // 
            // txtMiscellaneous
            // 
            this.txtMiscellaneous.Location = new System.Drawing.Point(115, 84);
            this.txtMiscellaneous.Name = "txtMiscellaneous";
            this.txtMiscellaneous.Size = new System.Drawing.Size(85, 27);
            this.txtMiscellaneous.TabIndex = 5;
            // 
            // lblMiscellaneous
            // 
            this.lblMiscellaneous.AutoSize = true;
            this.lblMiscellaneous.Location = new System.Drawing.Point(4, 87);
            this.lblMiscellaneous.Name = "lblMiscellaneous";
            this.lblMiscellaneous.Size = new System.Drawing.Size(105, 20);
            this.lblMiscellaneous.TabIndex = 4;
            this.lblMiscellaneous.Text = "&Miscellaneous:";
            this.lblMiscellaneous.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(115, 54);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(85, 27);
            this.txtTelephone.TabIndex = 3;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(28, 58);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(81, 20);
            this.lblTelephone.TabIndex = 2;
            this.lblTelephone.Text = "&Telephone:";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomService
            // 
            this.txtRoomService.Location = new System.Drawing.Point(115, 21);
            this.txtRoomService.Name = "txtRoomService";
            this.txtRoomService.Size = new System.Drawing.Size(85, 27);
            this.txtRoomService.TabIndex = 1;
            // 
            // lblRoomService
            // 
            this.lblRoomService.AutoSize = true;
            this.lblRoomService.Location = new System.Drawing.Point(6, 24);
            this.lblRoomService.Name = "lblRoomService";
            this.lblRoomService.Size = new System.Drawing.Size(103, 20);
            this.lblRoomService.TabIndex = 0;
            this.lblRoomService.Text = "&Room Service:";
            this.lblRoomService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpTotalCharges
            // 
            this.grpTotalCharges.Controls.Add(this.txtTotal);
            this.grpTotalCharges.Controls.Add(this.lblTotal);
            this.grpTotalCharges.Controls.Add(this.txtSubtotal);
            this.grpTotalCharges.Controls.Add(this.lblTax);
            this.grpTotalCharges.Controls.Add(this.lblSubtotal);
            this.grpTotalCharges.Controls.Add(this.txtAdditionalCharges);
            this.grpTotalCharges.Controls.Add(this.lblAdditionalCharges);
            this.grpTotalCharges.Controls.Add(this.txtRoomCharges);
            this.grpTotalCharges.Controls.Add(this.lblRoomCharges);
            this.grpTotalCharges.Location = new System.Drawing.Point(21, 273);
            this.grpTotalCharges.Name = "grpTotalCharges";
            this.grpTotalCharges.Size = new System.Drawing.Size(467, 195);
            this.grpTotalCharges.TabIndex = 5;
            this.grpTotalCharges.TabStop = false;
            this.grpTotalCharges.Text = "Total Charges";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(349, 90);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 27);
            this.txtSubtotal.TabIndex = 6;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(308, 126);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(33, 20);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax:";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(273, 93);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 20);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdditionalCharges
            // 
            this.txtAdditionalCharges.Location = new System.Drawing.Point(349, 57);
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.ReadOnly = true;
            this.txtAdditionalCharges.Size = new System.Drawing.Size(100, 27);
            this.txtAdditionalCharges.TabIndex = 3;
            this.txtAdditionalCharges.TabStop = false;
            this.txtAdditionalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAdditionalCharges
            // 
            this.lblAdditionalCharges.AutoSize = true;
            this.lblAdditionalCharges.Location = new System.Drawing.Point(202, 60);
            this.lblAdditionalCharges.Name = "lblAdditionalCharges";
            this.lblAdditionalCharges.Size = new System.Drawing.Size(139, 20);
            this.lblAdditionalCharges.TabIndex = 2;
            this.lblAdditionalCharges.Text = "Additional Charges:";
            this.lblAdditionalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomCharges
            // 
            this.txtRoomCharges.Location = new System.Drawing.Point(349, 24);
            this.txtRoomCharges.Name = "txtRoomCharges";
            this.txtRoomCharges.ReadOnly = true;
            this.txtRoomCharges.Size = new System.Drawing.Size(100, 27);
            this.txtRoomCharges.TabIndex = 1;
            this.txtRoomCharges.TabStop = false;
            this.txtRoomCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRoomCharges
            // 
            this.lblRoomCharges.AutoSize = true;
            this.lblRoomCharges.Location = new System.Drawing.Point(232, 27);
            this.lblRoomCharges.Name = "lblRoomCharges";
            this.lblRoomCharges.Size = new System.Drawing.Size(109, 20);
            this.lblRoomCharges.TabIndex = 0;
            this.lblRoomCharges.Text = "Room Charges:";
            this.lblRoomCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(370, 396);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 27);
            this.txtTax.TabIndex = 7;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(285, 474);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(296, 164);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(347, 157);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(102, 27);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RoomChargeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 515);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpTotalCharges);
            this.Controls.Add(this.grpAdditionalCharges);
            this.Controls.Add(this.grpRoomInformation);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "RoomChargeCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Charge Calculator";
            this.Load += new System.EventHandler(this.RoomChargeCalculatorForm_Load);
            this.grpRoomInformation.ResumeLayout(false);
            this.grpRoomInformation.PerformLayout();
            this.grpAdditionalCharges.ResumeLayout(false);
            this.grpAdditionalCharges.PerformLayout();
            this.grpTotalCharges.ResumeLayout(false);
            this.grpTotalCharges.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.GroupBox grpRoomInformation;
        private System.Windows.Forms.TextBox txtNightCharge;
        private System.Windows.Forms.Label lblNightCharge;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.GroupBox grpAdditionalCharges;
        private System.Windows.Forms.TextBox txtMiscellaneous;
        private System.Windows.Forms.Label lblMiscellaneous;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtRoomService;
        private System.Windows.Forms.Label lblRoomService;
        private System.Windows.Forms.GroupBox grpTotalCharges;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtAdditionalCharges;
        private System.Windows.Forms.Label lblAdditionalCharges;
        private System.Windows.Forms.TextBox txtRoomCharges;
        private System.Windows.Forms.Label lblRoomCharges;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

