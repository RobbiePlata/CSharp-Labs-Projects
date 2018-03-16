namespace Project_II_BookStore
{
    partial class TransactionSelectForm
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
            this.lblBookStore = new System.Windows.Forms.Label();
            this.lblTransactionPage = new System.Windows.Forms.Label();
            this.lblEnterForBook = new System.Windows.Forms.Label();
            this.txtEnterForBook1 = new System.Windows.Forms.TextBox();
            this.txtEnterForBook2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDash = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblEnterDataBelow = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOnHand = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtOnHand = new System.Windows.Forms.TextBox();
            this.txtTransactionDate = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblSelectTransaction = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookStore
            // 
            this.lblBookStore.AutoSize = true;
            this.lblBookStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookStore.Location = new System.Drawing.Point(197, 9);
            this.lblBookStore.Name = "lblBookStore";
            this.lblBookStore.Size = new System.Drawing.Size(209, 29);
            this.lblBookStore.TabIndex = 0;
            this.lblBookStore.Text = "Plata Book Store";
            // 
            // lblTransactionPage
            // 
            this.lblTransactionPage.AutoSize = true;
            this.lblTransactionPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionPage.Location = new System.Drawing.Point(230, 38);
            this.lblTransactionPage.Name = "lblTransactionPage";
            this.lblTransactionPage.Size = new System.Drawing.Size(133, 20);
            this.lblTransactionPage.TabIndex = 1;
            this.lblTransactionPage.Text = "Transaction Page";
            // 
            // lblEnterForBook
            // 
            this.lblEnterForBook.AutoSize = true;
            this.lblEnterForBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterForBook.Location = new System.Drawing.Point(12, 87);
            this.lblEnterForBook.Name = "lblEnterForBook";
            this.lblEnterForBook.Size = new System.Drawing.Size(391, 20);
            this.lblEnterForBook.TabIndex = 2;
            this.lblEnterForBook.Text = " Enter the ISBN for Book in (in form nnn-nnn) ...";
            // 
            // txtEnterForBook1
            // 
            this.txtEnterForBook1.Location = new System.Drawing.Point(409, 89);
            this.txtEnterForBook1.Name = "txtEnterForBook1";
            this.txtEnterForBook1.Size = new System.Drawing.Size(39, 20);
            this.txtEnterForBook1.TabIndex = 1;
            this.txtEnterForBook1.TextChanged += new System.EventHandler(this.txtEnterForBook1_TextChanged);
            // 
            // txtEnterForBook2
            // 
            this.txtEnterForBook2.Location = new System.Drawing.Point(465, 89);
            this.txtEnterForBook2.Name = "txtEnterForBook2";
            this.txtEnterForBook2.Size = new System.Drawing.Size(39, 20);
            this.txtEnterForBook2.TabIndex = 2;
            this.txtEnterForBook2.TextChanged += new System.EventHandler(this.txtEnterForBook2_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(510, 86);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(47, 25);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.Location = new System.Drawing.Point(449, 89);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(15, 20);
            this.lblDash.TabIndex = 6;
            this.lblDash.Text = "-";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(151, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(285, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD NEW BOOK TO INVENTORY";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(151, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(285, 28);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE A BOOK IN INVENTORY";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(151, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(285, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE A BOOK FROM INVENTORY";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Location = new System.Drawing.Point(35, 257);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(204, 13);
            this.lblControls.TabIndex = 10;
            this.lblControls.Text = "Group of Book Inventory Change Controls";
            // 
            // lblEnterDataBelow
            // 
            this.lblEnterDataBelow.AutoSize = true;
            this.lblEnterDataBelow.Location = new System.Drawing.Point(35, 279);
            this.lblEnterDataBelow.Name = "lblEnterDataBelow";
            this.lblEnterDataBelow.Size = new System.Drawing.Size(170, 13);
            this.lblEnterDataBelow.TabIndex = 11;
            this.lblEnterDataBelow.Text = "Enter Data for New Book Below ...";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(53, 326);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(39, 16);
            this.lblISBN.TabIndex = 12;
            this.lblISBN.Text = "ISBN";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(53, 358);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 16);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(53, 390);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 16);
            this.lblAuthor.TabIndex = 14;
            this.lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(302, 326);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 16);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // lblOnHand
            // 
            this.lblOnHand.AutoSize = true;
            this.lblOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnHand.Location = new System.Drawing.Point(302, 358);
            this.lblOnHand.Name = "lblOnHand";
            this.lblOnHand.Size = new System.Drawing.Size(61, 16);
            this.lblOnHand.TabIndex = 16;
            this.lblOnHand.Text = "On Hand";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionDate.Location = new System.Drawing.Point(302, 390);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(111, 16);
            this.lblTransactionDate.TabIndex = 17;
            this.lblTransactionDate.Text = "Transaction Date";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(105, 325);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(71, 20);
            this.txtISBN.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(105, 357);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(105, 389);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(424, 325);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtOnHand
            // 
            this.txtOnHand.Location = new System.Drawing.Point(424, 357);
            this.txtOnHand.Name = "txtOnHand";
            this.txtOnHand.Size = new System.Drawing.Size(100, 20);
            this.txtOnHand.TabIndex = 11;
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(424, 389);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionDate.TabIndex = 12;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(254, 426);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblSelectTransaction
            // 
            this.lblSelectTransaction.AutoSize = true;
            this.lblSelectTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTransaction.Location = new System.Drawing.Point(17, 111);
            this.lblSelectTransaction.Name = "lblSelectTransaction";
            this.lblSelectTransaction.Size = new System.Drawing.Size(166, 20);
            this.lblSelectTransaction.TabIndex = 25;
            this.lblSelectTransaction.Text = "Select a Transaction...";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(372, 268);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 26;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(453, 268);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 27;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // TransactionSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblSelectTransaction);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtTransactionDate);
            this.Controls.Add(this.txtOnHand);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.lblOnHand);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblEnterDataBelow);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEnterForBook2);
            this.Controls.Add(this.txtEnterForBook1);
            this.Controls.Add(this.lblEnterForBook);
            this.Controls.Add(this.lblTransactionPage);
            this.Controls.Add(this.lblBookStore);
            this.Name = "TransactionSelectForm";
            this.Text = "TransactionSelectForm";
            this.Load += new System.EventHandler(this.TransactionSelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookStore;
        private System.Windows.Forms.Label lblTransactionPage;
        private System.Windows.Forms.Label lblEnterForBook;
        private System.Windows.Forms.TextBox txtEnterForBook1;
        private System.Windows.Forms.TextBox txtEnterForBook2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label lblEnterDataBelow;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOnHand;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtOnHand;
        private System.Windows.Forms.TextBox txtTransactionDate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblSelectTransaction;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}