using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PointCoords
{
    public partial class Form1 : Form
    {
        PointRecorder myPointRecorder;        
        public Form1()
        {
            InitializeComponent();
            myPointRecorder = new PointRecorder();
        }

        private void cmdSaveCoords_Click(object sender, EventArgs e)
        {
            myPointRecorder.AddPoint(System.Convert.ToDouble(txtXcoords.Text), System.Convert.ToDouble(txtYcoords.Text));
            txtXcoords.Text = ""; txtYcoords.Text = ""; txtXcoords.Focus();
        }

        private void cmdAusgabe_Click(object sender, EventArgs e)
        {
            foreach (Point p in myPointRecorder.PointList)
                {
                    lboxcoords.Items.Add(System.Convert.ToDouble(p.Xcoord) + ";" + System.Convert.ToDouble(p.Ycoord));
                }
        }

        private void cmdClearLbox_Click(object sender, EventArgs e)
        {
            lboxcoords.Items.Clear();
        }

        private void cmdWriteCoords_Click(object sender, EventArgs e)
        {
            string msg="Unknown write error";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (radioButtonText.Checked)
                        myPointRecorder.WriteToFile(saveFileDialog1.FileName);
                    if (radioButtonBin.Checked)
                        myPointRecorder.WriteToFileBin(saveFileDialog1.FileName);
                    msg = "File successfully written!";
                }
                catch(IOException ex)
                {
                    msg = "IOError writing to file: " + ex.Message;  
                }
                catch (Exception ex)
                {
                    msg = "Error writing to file: " + ex.Message;
                }
                finally
                {                    
                    MessageBox.Show(msg);
                }
            }
        }

        private void cmdReadCoords_Click(object sender, EventArgs e)
        {            
            string msg = "Unknown read error";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (radioButtonText.Checked)
                        myPointRecorder.ReadFromFile(openFileDialog1.FileName);
                    if (radioButtonBin.Checked)
                        myPointRecorder.ReadFromFileBin(openFileDialog1.FileName);
                    msg = "File read successfully!";
                    updateListbox();
                }
                catch (IOException ex)
                {
                    msg = "IOError reading from file: " + ex.Message;
                }
                catch (Exception ex)
                {
                    msg = "Error reading from file: " + ex.Message;
                }
                finally
                {
                    MessageBox.Show(msg);
                }
            }      
        }

        private void updateListbox()
        {
            lboxcoords.Items.Clear();
            foreach (Point p in myPointRecorder.PointList)
            {
                lboxcoords.Items.Add(System.Convert.ToString(p.Xcoord) + ";" + System.Convert.ToString(p.Ycoord));
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Point key = new Point();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (radioButtonText.Checked)
                        key = myPointRecorder.GetPoint( System.Convert.ToInt32(txt_Index.Text));
                    if (radioButtonBin.Checked)
                        key = myPointRecorder.GetPointBin(openFileDialog1.FileName, System.Convert.ToInt32(txt_Index.Text));
                    MessageBox.Show(Convert.ToString(key.Xcoord) + " ; " + Convert.ToString(key.Ycoord));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}