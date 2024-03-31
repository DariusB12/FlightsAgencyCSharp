using System.ComponentModel;
using ProjectCS.model;
using ProjectCS.utils.factory;

namespace WindowsFormsApplication1
{
    partial class MainController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAllFlights = new System.Windows.Forms.ListBox();
            this.listBoxSearchedFlights = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTouristNames = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownNoOfSeats = new System.Windows.Forms.NumericUpDown();
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listViewAllFlights = new System.Windows.Forms.ListView();
            this.listViewSearchedFlights = new System.Windows.Forms.ListView();
            this.buttonAddTourist = new System.Windows.Forms.Button();
            this.listBoxTouristNames = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRemoveToruist = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxSelectedFlight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "flights";
            // 
            // listBoxAllFlights
            // 
            this.listBoxAllFlights.Location = new System.Drawing.Point(0, 0);
            this.listBoxAllFlights.Name = "listBoxAllFlights";
            this.listBoxAllFlights.Size = new System.Drawing.Size(120, 96);
            this.listBoxAllFlights.TabIndex = 0;
            // 
            // listBoxSearchedFlights
            // 
            this.listBoxSearchedFlights.Location = new System.Drawing.Point(0, 0);
            this.listBoxSearchedFlights.Name = "listBoxSearchedFlights";
            this.listBoxSearchedFlights.Size = new System.Drawing.Size(120, 96);
            this.listBoxSearchedFlights.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(987, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "DepartureDate";
            // 
            // dateTimePickerDepartureTime
            // 
            this.dateTimePickerDepartureTime.Location = new System.Drawing.Point(987, 30);
            this.dateTimePickerDepartureTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
            this.dateTimePickerDepartureTime.Size = new System.Drawing.Size(274, 26);
            this.dateTimePickerDepartureTime.TabIndex = 5;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(670, 30);
            this.textBoxDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(311, 26);
            this.textBoxDestination.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1267, 30);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(78, 24);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "ClientName";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "ClientAddress";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(648, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "TouristNames";
            // 
            // textBoxTouristNames
            // 
            this.textBoxTouristNames.Location = new System.Drawing.Point(787, 376);
            this.textBoxTouristNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTouristNames.Name = "textBoxTouristNames";
            this.textBoxTouristNames.Size = new System.Drawing.Size(237, 26);
            this.textBoxTouristNames.TabIndex = 11;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(153, 366);
            this.textBoxClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(483, 26);
            this.textBoxClientName.TabIndex = 12;
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Location = new System.Drawing.Point(153, 413);
            this.textBoxClientAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(483, 26);
            this.textBoxClientAddress.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "NoOfSeats";
            // 
            // numericUpDownNoOfSeats
            // 
            this.numericUpDownNoOfSeats.Location = new System.Drawing.Point(787, 420);
            this.numericUpDownNoOfSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownNoOfSeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownNoOfSeats.Name = "numericUpDownNoOfSeats";
            this.numericUpDownNoOfSeats.Size = new System.Drawing.Size(75, 26);
            this.numericUpDownNoOfSeats.TabIndex = 15;
            this.numericUpDownNoOfSeats.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.BackColor = System.Drawing.SystemColors.Info;
            this.buttonBuyTicket.ForeColor = System.Drawing.Color.Black;
            this.buttonBuyTicket.Location = new System.Drawing.Point(787, 460);
            this.buttonBuyTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(183, 34);
            this.buttonBuyTicket.TabIndex = 16;
            this.buttonBuyTicket.Text = "BuyTicket";
            this.buttonBuyTicket.UseVisualStyleBackColor = false;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listViewAllFlights
            // 
            this.listViewAllFlights.FullRowSelect = true;
            this.listViewAllFlights.GridLines = true;
            this.listViewAllFlights.HideSelection = false;
            this.listViewAllFlights.Location = new System.Drawing.Point(12, 52);
            this.listViewAllFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewAllFlights.Name = "listViewAllFlights";
            this.listViewAllFlights.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewAllFlights.Size = new System.Drawing.Size(624, 272);
            this.listViewAllFlights.TabIndex = 17;
            this.listViewAllFlights.UseCompatibleStateImageBehavior = false;
            this.listViewAllFlights.View = System.Windows.Forms.View.List;
            this.listViewAllFlights.SelectedIndexChanged += new System.EventHandler(this.listViewAllFlights_SelectedIndexChanged);
            // 
            // listViewSearchedFlights
            // 
            this.listViewSearchedFlights.FullRowSelect = true;
            this.listViewSearchedFlights.HideSelection = false;
            this.listViewSearchedFlights.Location = new System.Drawing.Point(670, 58);
            this.listViewSearchedFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewSearchedFlights.Name = "listViewSearchedFlights";
            this.listViewSearchedFlights.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewSearchedFlights.Size = new System.Drawing.Size(730, 266);
            this.listViewSearchedFlights.TabIndex = 18;
            this.listViewSearchedFlights.UseCompatibleStateImageBehavior = false;
            this.listViewSearchedFlights.View = System.Windows.Forms.View.List;
            this.listViewSearchedFlights.SelectedIndexChanged += new System.EventHandler(this.listViewSearchedFlights_SelectedIndexChanged);
            // 
            // buttonAddTourist
            // 
            this.buttonAddTourist.Location = new System.Drawing.Point(1030, 367);
            this.buttonAddTourist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTourist.Name = "buttonAddTourist";
            this.buttonAddTourist.Size = new System.Drawing.Size(147, 36);
            this.buttonAddTourist.TabIndex = 19;
            this.buttonAddTourist.Text = "AddTourist";
            this.buttonAddTourist.UseVisualStyleBackColor = true;
            this.buttonAddTourist.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxTouristNames
            // 
            this.listBoxTouristNames.FormattingEnabled = true;
            this.listBoxTouristNames.ItemHeight = 18;
            this.listBoxTouristNames.Location = new System.Drawing.Point(1200, 366);
            this.listBoxTouristNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTouristNames.Name = "listBoxTouristNames";
            this.listBoxTouristNames.Size = new System.Drawing.Size(200, 130);
            this.listBoxTouristNames.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1223, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "TouristNmaesList";
            // 
            // buttonRemoveToruist
            // 
            this.buttonRemoveToruist.Location = new System.Drawing.Point(1030, 412);
            this.buttonRemoveToruist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveToruist.Name = "buttonRemoveToruist";
            this.buttonRemoveToruist.Size = new System.Drawing.Size(147, 36);
            this.buttonRemoveToruist.TabIndex = 22;
            this.buttonRemoveToruist.Text = "RemoveTourist";
            this.buttonRemoveToruist.UseVisualStyleBackColor = true;
            this.buttonRemoveToruist.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1030, 459);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(147, 36);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxSelectedFlight
            // 
            this.textBoxSelectedFlight.Location = new System.Drawing.Point(357, 329);
            this.textBoxSelectedFlight.Name = "textBoxSelectedFlight";
            this.textBoxSelectedFlight.ReadOnly = true;
            this.textBoxSelectedFlight.Size = new System.Drawing.Size(624, 26);
            this.textBoxSelectedFlight.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(227, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "SelectedFlight";
            // 
            // MainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1413, 501);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSelectedFlight);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemoveToruist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxTouristNames);
            this.Controls.Add(this.buttonAddTourist);
            this.Controls.Add(this.listViewSearchedFlights);
            this.Controls.Add(this.listViewAllFlights);
            this.Controls.Add(this.buttonBuyTicket);
            this.Controls.Add(this.numericUpDownNoOfSeats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxClientAddress);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.textBoxTouristNames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.dateTimePickerDepartureTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainController";
            this.Text = "MainController";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.TextBox textBoxSelectedFlight;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.Button buttonRemoveToruist;

        private System.Windows.Forms.Button buttonAddTourist;
        private System.Windows.Forms.ListBox listBoxTouristNames;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.ListView listViewAllFlights;
        private System.Windows.Forms.ListView listViewSearchedFlights;

        private System.Windows.Forms.ListView listView1;

        private System.Windows.Forms.NumericUpDown numericUpDownNoOfSeats;
        private System.Windows.Forms.Button buttonBuyTicket;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientAddress;

        private System.Windows.Forms.TextBox textBoxTouristNames;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureTime;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonSearch;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ListBox listBoxAllFlights;
        private System.Windows.Forms.ListBox listBoxSearchedFlights;


        private System.Windows.Forms.Label label1;

        #endregion
    }
}