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
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "flights";
            // 
            // treeView1
            // 
            this.treeView1.LineColor = System.Drawing.Color.Empty;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(898, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1215, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "DepartureDate";
            // 
            // dateTimePickerDepartureTime
            // 
            this.dateTimePickerDepartureTime.Location = new System.Drawing.Point(1215, 27);
            this.dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
            this.dateTimePickerDepartureTime.Size = new System.Drawing.Size(274, 26);
            this.dateTimePickerDepartureTime.TabIndex = 5;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(898, 27);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(311, 26);
            this.textBoxDestination.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1495, 26);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(78, 26);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "ClientName";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "ClientAddress";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(832, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "TouristNames";
            // 
            // textBoxTouristNames
            // 
            this.textBoxTouristNames.Location = new System.Drawing.Point(972, 409);
            this.textBoxTouristNames.Name = "textBoxTouristNames";
            this.textBoxTouristNames.Size = new System.Drawing.Size(561, 26);
            this.textBoxTouristNames.TabIndex = 11;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(153, 407);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(659, 26);
            this.textBoxClientName.TabIndex = 12;
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Location = new System.Drawing.Point(153, 459);
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(659, 26);
            this.textBoxClientAddress.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(832, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "NoOfSeats";
            // 
            // numericUpDownNoOfSeats
            // 
            this.numericUpDownNoOfSeats.Location = new System.Drawing.Point(972, 459);
            this.numericUpDownNoOfSeats.Name = "numericUpDownNoOfSeats";
            this.numericUpDownNoOfSeats.Size = new System.Drawing.Size(75, 26);
            this.numericUpDownNoOfSeats.TabIndex = 15;
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.Location = new System.Drawing.Point(1215, 454);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(183, 36);
            this.buttonBuyTicket.TabIndex = 16;
            this.buttonBuyTicket.Text = "BuyTicket";
            this.buttonBuyTicket.UseVisualStyleBackColor = true;
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
            this.listViewAllFlights.HideSelection = false;
            this.listViewAllFlights.Location = new System.Drawing.Point(14, 58);
            this.listViewAllFlights.Name = "listViewAllFlights";
            this.listViewAllFlights.Size = new System.Drawing.Size(853, 302);
            this.listViewAllFlights.TabIndex = 17;
            this.listViewAllFlights.UseCompatibleStateImageBehavior = false;
            this.listViewAllFlights.View = System.Windows.Forms.View.SmallIcon;
            // 
            // listViewSearchedFlights
            // 
            this.listViewSearchedFlights.HideSelection = false;
            this.listViewSearchedFlights.Location = new System.Drawing.Point(898, 58);
            this.listViewSearchedFlights.Name = "listViewSearchedFlights";
            this.listViewSearchedFlights.Size = new System.Drawing.Size(878, 302);
            this.listViewSearchedFlights.TabIndex = 18;
            this.listViewSearchedFlights.UseCompatibleStateImageBehavior = false;
            this.listViewSearchedFlights.View = System.Windows.Forms.View.SmallIcon;
            // 
            // MainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 555);
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
            this.Name = "MainController";
            this.Text = "MainController";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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

        private System.Windows.Forms.TreeView treeView1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}