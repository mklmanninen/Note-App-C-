using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp2
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable(); //Acts as a BackEnd
        bool editing = false; //If we are editing a note or not
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title"); //Storing the title to the DataTable
            notes.Columns.Add("Note");  //Storing the note to the DataTable

            previousNotes.DataSource = notes;  //the Data grid box works as a DataSource. 

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();

            }
            catch(Exception ex) { Console.WriteLine("Not a valid note"); }
            

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = string.Empty;
            noteBox.Text = string.Empty;   

            previousNotes.DataSource = notes;

        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;

        }
    }
}
