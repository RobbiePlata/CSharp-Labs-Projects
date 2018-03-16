// Class: updatedFileClass
// Class Description: To write information out to a desired text file location path
// Robert Plata
// 3/10/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_II_BookStore
{
    class updatedFileClass
    {
        private String updatedFilePath; // File Path to be written to
        private System.IO.StreamWriter updatedFileSW; // Reference variable of type StreamWriter
        private int recordWrittenCount; // Count of records written to file

        // Constructor with file path output
        // Create instance of StreamWriter class (type) and store reference
        public updatedFileClass(string filePath)
        {
            this.updatedFilePath = filePath;
            recordWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.",
                                "Output File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end try
        } // end updatedFileClass Constructor

        // Write a record from updated file
        public void writeNextRecord(string str)
        {
            updatedFileSW.WriteLine(str); // write line to file
            recordWrittenCount++;
        }

        // Return number of records written to file
        public int getRecordWrittenCount()
        {
            return recordWrittenCount;
        }

        // Close the output file
        public void closeFile()
        {
            updatedFileSW.Close();
        } // end 
    }
}
