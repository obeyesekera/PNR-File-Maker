
namespace PNR_File_Maker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.txtNoofSeatofFlight = new System.Windows.Forms.TextBox();
            this.txtFlightSeatType = new System.Windows.Forms.TextBox();
            this.txtNoOfBusinessClassRows = new System.Windows.Forms.TextBox();
            this.txtNoOfPremiumClassRows = new System.Windows.Forms.TextBox();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.txtDestinationPort = new System.Windows.Forms.TextBox();
            this.txtOriginPort = new System.Windows.Forms.TextBox();
            this.txtNoofPassengers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dtArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.dtDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.btnCopyPax = new System.Windows.Forms.Button();
            this.btnAddPax = new System.Windows.Forms.Button();
            this.btnDelPax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(244, 12);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(273, 31);
            this.txtFlightNumber.TabIndex = 0;
            // 
            // txtNoofSeatofFlight
            // 
            this.txtNoofSeatofFlight.Location = new System.Drawing.Point(244, 69);
            this.txtNoofSeatofFlight.Name = "txtNoofSeatofFlight";
            this.txtNoofSeatofFlight.Size = new System.Drawing.Size(273, 31);
            this.txtNoofSeatofFlight.TabIndex = 2;
            // 
            // txtFlightSeatType
            // 
            this.txtFlightSeatType.Location = new System.Drawing.Point(800, 69);
            this.txtFlightSeatType.Name = "txtFlightSeatType";
            this.txtFlightSeatType.Size = new System.Drawing.Size(273, 31);
            this.txtFlightSeatType.TabIndex = 3;
            // 
            // txtNoOfBusinessClassRows
            // 
            this.txtNoOfBusinessClassRows.Location = new System.Drawing.Point(244, 106);
            this.txtNoOfBusinessClassRows.Name = "txtNoOfBusinessClassRows";
            this.txtNoOfBusinessClassRows.Size = new System.Drawing.Size(273, 31);
            this.txtNoOfBusinessClassRows.TabIndex = 4;
            // 
            // txtNoOfPremiumClassRows
            // 
            this.txtNoOfPremiumClassRows.Location = new System.Drawing.Point(800, 106);
            this.txtNoOfPremiumClassRows.Name = "txtNoOfPremiumClassRows";
            this.txtNoOfPremiumClassRows.Size = new System.Drawing.Size(273, 31);
            this.txtNoOfPremiumClassRows.TabIndex = 5;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(800, 206);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(150, 31);
            this.txtArrivalDate.TabIndex = 10;
            // 
            // txtDestinationPort
            // 
            this.txtDestinationPort.Location = new System.Drawing.Point(800, 169);
            this.txtDestinationPort.Name = "txtDestinationPort";
            this.txtDestinationPort.Size = new System.Drawing.Size(273, 31);
            this.txtDestinationPort.TabIndex = 9;
            // 
            // txtOriginPort
            // 
            this.txtOriginPort.Location = new System.Drawing.Point(244, 169);
            this.txtOriginPort.Name = "txtOriginPort";
            this.txtOriginPort.Size = new System.Drawing.Size(273, 31);
            this.txtOriginPort.TabIndex = 6;
            // 
            // txtNoofPassengers
            // 
            this.txtNoofPassengers.Location = new System.Drawing.Point(800, 12);
            this.txtNoofPassengers.Name = "txtNoofPassengers";
            this.txtNoofPassengers.Size = new System.Drawing.Size(273, 31);
            this.txtNoofPassengers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Flight Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "No of Seat of Flight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Flight Seat Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "No Of Business Class Rows";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "No Of Premium Class Rows";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Arrival Date Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Departure Date Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Destination Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Origin Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "No of Passengers";
            // 
            // dataGridView
            // 
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView.Location = new System.Drawing.Point(21, 272);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1051, 399);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            this.dataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Wingdings", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(1117, 77);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 60);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "1";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1117, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 60);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "<";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(1117, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(60, 60);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "2";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtArrivalTime
            // 
            this.dtArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtArrivalTime.Location = new System.Drawing.Point(956, 206);
            this.dtArrivalTime.Name = "dtArrivalTime";
            this.dtArrivalTime.Size = new System.Drawing.Size(117, 31);
            this.dtArrivalTime.TabIndex = 11;
            this.dtArrivalTime.ValueChanged += new System.EventHandler(this.dtArrivalTime_ValueChanged);
            // 
            // dtDepartureTime
            // 
            this.dtDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtDepartureTime.Location = new System.Drawing.Point(400, 206);
            this.dtDepartureTime.Name = "dtDepartureTime";
            this.dtDepartureTime.Size = new System.Drawing.Size(117, 31);
            this.dtDepartureTime.TabIndex = 8;
            this.dtDepartureTime.ValueChanged += new System.EventHandler(this.dtDepartureTime_ValueChanged);
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(244, 206);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(150, 31);
            this.txtDepartureDate.TabIndex = 7;
            // 
            // btnCopyPax
            // 
            this.btnCopyPax.Font = new System.Drawing.Font("Wingdings", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopyPax.Location = new System.Drawing.Point(1078, 419);
            this.btnCopyPax.Name = "btnCopyPax";
            this.btnCopyPax.Size = new System.Drawing.Size(40, 40);
            this.btnCopyPax.TabIndex = 17;
            this.btnCopyPax.Text = "4";
            this.btnCopyPax.UseVisualStyleBackColor = true;
            this.btnCopyPax.Click += new System.EventHandler(this.btnDuplicateRow_Click);
            // 
            // btnAddPax
            // 
            this.btnAddPax.Font = new System.Drawing.Font("Wingdings", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPax.Location = new System.Drawing.Point(1078, 373);
            this.btnAddPax.Name = "btnAddPax";
            this.btnAddPax.Size = new System.Drawing.Size(40, 40);
            this.btnAddPax.TabIndex = 16;
            this.btnAddPax.Text = "!";
            this.btnAddPax.UseVisualStyleBackColor = true;
            this.btnAddPax.Click += new System.EventHandler(this.btnAddPax_Click);
            // 
            // btnDelPax
            // 
            this.btnDelPax.Font = new System.Drawing.Font("Wingdings", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelPax.Location = new System.Drawing.Point(1078, 465);
            this.btnDelPax.Name = "btnDelPax";
            this.btnDelPax.Size = new System.Drawing.Size(40, 40);
            this.btnDelPax.TabIndex = 18;
            this.btnDelPax.Text = "\"";
            this.btnDelPax.UseVisualStyleBackColor = true;
            this.btnDelPax.Click += new System.EventHandler(this.btnDelPax_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 684);
            this.Controls.Add(this.btnDelPax);
            this.Controls.Add(this.btnAddPax);
            this.Controls.Add(this.btnCopyPax);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.dtDepartureTime);
            this.Controls.Add(this.dtArrivalTime);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.txtDestinationPort);
            this.Controls.Add(this.txtOriginPort);
            this.Controls.Add(this.txtNoofPassengers);
            this.Controls.Add(this.txtNoOfPremiumClassRows);
            this.Controls.Add(this.txtNoOfBusinessClassRows);
            this.Controls.Add(this.txtFlightSeatType);
            this.Controls.Add(this.txtNoofSeatofFlight);
            this.Controls.Add(this.txtFlightNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "PNR File Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.TextBox txtNoofSeatofFlight;
        private System.Windows.Forms.TextBox txtFlightSeatType;
        private System.Windows.Forms.TextBox txtNoOfBusinessClassRows;
        private System.Windows.Forms.TextBox txtNoOfPremiumClassRows;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.TextBox txtDestinationPort;
        private System.Windows.Forms.TextBox txtOriginPort;
        private System.Windows.Forms.TextBox txtNoofPassengers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DateTimePicker dtArrivalTime;
        private System.Windows.Forms.DateTimePicker dtDepartureTime;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.Button btnCopyPax;
        private System.Windows.Forms.Button btnAddPax;
        private System.Windows.Forms.Button btnDelPax;
    }
}

