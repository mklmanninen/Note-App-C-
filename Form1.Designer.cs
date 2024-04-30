namespace NoteApp2
{
    partial class NoteTaker
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(383, 24);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(414, 20);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(383, 74);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(405, 364);
            this.noteBox.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(380, -2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(408, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title:";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Note
            // 
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(380, 48);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(408, 23);
            this.Note.TabIndex = 3;
            this.Note.Text = "Note:";
            this.Note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previousNotes
            // 
            this.previousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previousNotes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(12, 12);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.Size = new System.Drawing.Size(362, 333);
            this.previousNotes.TabIndex = 4;
            this.previousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellDoubleClick);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.CadetBlue;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(12, 351);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(174, 40);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(192, 351);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(182, 40);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Moccasin;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(192, 398);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(182, 40);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.LightBlue;
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(12, 398);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(174, 40);
            this.NewButton.TabIndex = 8;
            this.NewButton.Text = "New Note";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "NoteTaker";
            this.Text = "NoteTaker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.DataGridView previousNotes;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
    }
}

