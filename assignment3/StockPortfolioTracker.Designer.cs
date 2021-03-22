
namespace assignment3
{
    partial class StockPortfolioTracker
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnSell = new System.Windows.Forms.RadioButton();
            this.rbtnBuy = new System.Windows.Forms.RadioButton();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtSharePrice = new System.Windows.Forms.TextBox();
            this.txtNumberOfShares = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtTicketSymbol = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetNewID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnDisplayTransactions = new System.Windows.Forms.Button();
            this.btnEmptyFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.rtxtMessages = new System.Windows.Forms.RichTextBox();
            this.rtxtDisplay = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(21, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(127, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "File Name and Path:";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(24, 38);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(320, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(350, 35);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(154, 32);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Create/Open File";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtNote);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.rbtnSell);
            this.groupBox1.Controls.Add(this.rbtnBuy);
            this.groupBox1.Controls.Add(this.txtCommission);
            this.groupBox1.Controls.Add(this.txtSharePrice);
            this.groupBox1.Controls.Add(this.txtNumberOfShares);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.txtTicketSymbol);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetNewID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 494);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Transaction";
            // 
            // rtxtNote
            // 
            this.rtxtNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNote.Location = new System.Drawing.Point(49, 211);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(283, 104);
            this.rtxtNote.TabIndex = 10;
            this.rtxtNote.Text = "";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy/MM/dd";
            this.date.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(73, 168);
            this.date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(248, 22);
            this.date.TabIndex = 9;
            this.date.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(229, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 32);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(121, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 32);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(17, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnSell
            // 
            this.rbtnSell.AutoSize = true;
            this.rbtnSell.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSell.Location = new System.Drawing.Point(239, 139);
            this.rbtnSell.Name = "rbtnSell";
            this.rbtnSell.Size = new System.Drawing.Size(48, 20);
            this.rbtnSell.TabIndex = 8;
            this.rbtnSell.Text = "Sell";
            this.rbtnSell.UseVisualStyleBackColor = true;
            // 
            // rbtnBuy
            // 
            this.rbtnBuy.AutoSize = true;
            this.rbtnBuy.Checked = true;
            this.rbtnBuy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBuy.Location = new System.Drawing.Point(144, 139);
            this.rbtnBuy.Name = "rbtnBuy";
            this.rbtnBuy.Size = new System.Drawing.Size(49, 20);
            this.rbtnBuy.TabIndex = 7;
            this.rbtnBuy.TabStop = true;
            this.rbtnBuy.Text = "Buy";
            this.rbtnBuy.UseVisualStyleBackColor = true;
            // 
            // txtCommission
            // 
            this.txtCommission.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.Location = new System.Drawing.Point(126, 411);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(142, 22);
            this.txtCommission.TabIndex = 13;
            // 
            // txtSharePrice
            // 
            this.txtSharePrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSharePrice.Location = new System.Drawing.Point(126, 341);
            this.txtSharePrice.Name = "txtSharePrice";
            this.txtSharePrice.Size = new System.Drawing.Size(142, 22);
            this.txtSharePrice.TabIndex = 11;
            // 
            // txtNumberOfShares
            // 
            this.txtNumberOfShares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfShares.Location = new System.Drawing.Point(126, 374);
            this.txtNumberOfShares.Name = "txtNumberOfShares";
            this.txtNumberOfShares.Size = new System.Drawing.Size(142, 22);
            this.txtNumberOfShares.TabIndex = 12;
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(126, 93);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(142, 22);
            this.txtCompany.TabIndex = 6;
            // 
            // txtTicketSymbol
            // 
            this.txtTicketSymbol.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketSymbol.Location = new System.Drawing.Point(126, 61);
            this.txtTicketSymbol.Name = "txtTicketSymbol";
            this.txtTicketSymbol.Size = new System.Drawing.Size(67, 22);
            this.txtTicketSymbol.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(126, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(67, 22);
            this.txtID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transaction ID:";
            // 
            // btnGetNewID
            // 
            this.btnGetNewID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetNewID.Location = new System.Drawing.Point(204, 24);
            this.btnGetNewID.Name = "btnGetNewID";
            this.btnGetNewID.Size = new System.Drawing.Size(83, 28);
            this.btnGetNewID.TabIndex = 4;
            this.btnGetNewID.Text = "Get New ID";
            this.btnGetNewID.UseVisualStyleBackColor = true;
            this.btnGetNewID.Click += new System.EventHandler(this.btnGetNewID_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Note:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Commission:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Number of Shares:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Share Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Transaction Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Company:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ticket Symbol:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTransactionID);
            this.groupBox2.Controls.Add(this.btnDeleteTransaction);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 579);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 63);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Transaction";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Transaction ID:";
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionID.Location = new System.Drawing.Point(126, 25);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(67, 22);
            this.txtTransactionID.TabIndex = 17;
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTransaction.Location = new System.Drawing.Point(204, 23);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(132, 27);
            this.btnDeleteTransaction.TabIndex = 18;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // btnDisplayTransactions
            // 
            this.btnDisplayTransactions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayTransactions.Location = new System.Drawing.Point(382, 597);
            this.btnDisplayTransactions.Name = "btnDisplayTransactions";
            this.btnDisplayTransactions.Size = new System.Drawing.Size(166, 37);
            this.btnDisplayTransactions.TabIndex = 19;
            this.btnDisplayTransactions.Text = "Display Transactions";
            this.btnDisplayTransactions.UseVisualStyleBackColor = true;
            this.btnDisplayTransactions.Click += new System.EventHandler(this.btnDisplayTransactions_Click);
            // 
            // btnEmptyFile
            // 
            this.btnEmptyFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyFile.Location = new System.Drawing.Point(559, 597);
            this.btnEmptyFile.Name = "btnEmptyFile";
            this.btnEmptyFile.Size = new System.Drawing.Size(119, 37);
            this.btnEmptyFile.TabIndex = 20;
            this.btnEmptyFile.Text = "Empty File";
            this.btnEmptyFile.UseVisualStyleBackColor = true;
            this.btnEmptyFile.Click += new System.EventHandler(this.btnEmptyFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(688, 597);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 37);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(902, 579);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Messages:";
            // 
            // rtxtMessages
            // 
            this.rtxtMessages.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMessages.Location = new System.Drawing.Point(980, 576);
            this.rtxtMessages.Name = "rtxtMessages";
            this.rtxtMessages.Size = new System.Drawing.Size(482, 58);
            this.rtxtMessages.TabIndex = 21;
            this.rtxtMessages.TabStop = false;
            this.rtxtMessages.Text = "";
            // 
            // rtxtDisplay
            // 
            this.rtxtDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDisplay.Location = new System.Drawing.Point(382, 84);
            this.rtxtDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.rtxtDisplay.Name = "rtxtDisplay";
            this.rtxtDisplay.Size = new System.Drawing.Size(1105, 484);
            this.rtxtDisplay.TabIndex = 5;
            this.rtxtDisplay.TabStop = false;
            this.rtxtDisplay.Text = "";
            // 
            // StockPortfolioTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 652);
            this.Controls.Add(this.rtxtDisplay);
            this.Controls.Add(this.rtxtMessages);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmptyFile);
            this.Controls.Add(this.btnDisplayTransactions);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lbl);
            this.Name = "StockPortfolioTracker";
            this.Text = "Stock Portfolio Tracker";
            this.Load += new System.EventHandler(this.StockPortfolioTracker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetNewID;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RadioButton rbtnSell;
        private System.Windows.Forms.RadioButton rbtnBuy;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtTicketSymbol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtSharePrice;
        private System.Windows.Forms.TextBox txtNumberOfShares;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Button btnDisplayTransactions;
        private System.Windows.Forms.Button btnEmptyFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtxtMessages;
        private System.Windows.Forms.RichTextBox rtxtDisplay;
        private System.Windows.Forms.Button btnUpdate;
    }
}

