
namespace NoteAppUI
{
    partial class NoteForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.noteTextTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noteTextTextBox
            // 
            this.noteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteTextTextBox.Location = new System.Drawing.Point(15, 117);
            this.noteTextTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noteTextTextBox.Multiline = true;
            this.noteTextTextBox.Name = "noteTextTextBox";
            this.noteTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.noteTextTextBox.Size = new System.Drawing.Size(708, 482);
            this.noteTextTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(515, 613);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(623, 613);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(113, 47);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(204, 28);
            this.CategoryComboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Title:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(113, 11);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(613, 26);
            this.nameTextBox.TabIndex = 20;
           
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ModifiedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(365, 82);
            this.ModifiedDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(136, 27);
            this.ModifiedDateTimePicker.TabIndex = 24;
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.CreatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(113, 82);
            this.CreatedDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(136, 27);
            this.CreatedDateTimePicker.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(272, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Modified:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Created:";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 654);
            this.Controls.Add(this.ModifiedDateTimePicker);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.noteTextTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add/Edit Note";
            this.Load += new System.EventHandler(this.Add_EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteTextTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}