using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Far3na : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-87G6M1G\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        //SqlCommand cmd;
        //SqlDataAdapter adapt;
        ////ID variable used in Updating and Deleting Record  
        //int ID = 0;

        public Far3na()
        {
            InitializeComponent();
        } /*                                                                                                    RRRRRRRRRRRRRRRRRRRRRRRR                                                                                               
                                                                                                                RRRRRRR................RRR                
                                                                                                                RRRRRRRR................RRRR                                                    
                                                                                            AAA                 RRRRRRRR.................RRRR                                           
          OOOOOOOOOOOO                  MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                AAAAA                R....RRR................RRRRR
       OOOO...........OOO               MMMMMMMM ..................MMMMMMMM               AAAAAAA               RRRRRR.................RRRRRR
     OOO................OOO             M......MMM...............MMM......M              AAAAAAAAA              R....RR...............RRRRRRR
    OOOO.................OOOO           M......M MM.............MM M......M             AAAA...AAAA             R....RR.............RRRRRRRR                       
   OOOOO..................OOOO          M......M  MM...........MM  M......M            AAAAA...AAAAA            R....RRRRRRRRRRRRRRRRRRRRR                 
    OOOOO.................OOOO          M......M   MM.........MM   M......M           AAAAAAAAAAAAAAA           R....RRR....RR....RRR....R          
     OOOO.................OOO           M......M    MM.......MM    M......M          AAAAAAAAAAAAAAAAA          R....R              R....R       
      OOOOO............OOOOO            M......M     MM.....MM     M......M         AAAAA.........AAAAA         R....R              R....R                                              
       OOOO............OOOO             M......M      MM...MM      M......M        AAAAA...........AAAAA        R....R              R....R
         OOOOOOOOOOOOOOO                M......M     MMMMMMMMM     M......M       AAAAA.............AAAAA       R....R              R....R
                                                                                AAAAAAAAAA........AAAAAAAAA    RRRRRRRR           RRRRRRRRR   
                                                                                                                
         */
        private void Far3na_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tableDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.tableDataSet.Table1);
            // TODO: This line of code loads data into the 'far3na_HotelDataSet1.Far3na_Hotel_System' table. You can move, or remove it, as needed.
            //   this.far3naHotelSystemTableAdapter.Fill(this.far3na_HotelDataSet1.Far3na_Hotel_System);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   far3naHotelSystemBindingSource.AddNew();
            if (textBox1!=null && textBox2!=null)
            {
                table1BindingSource.AddNew();
                label7.Text = "Added Done (:";
              
            }
            else
            {
               MessageBox.Show(" Plz Eneter The Information", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            table1BindingSource.EndEdit();
            table1TableAdapter.Update(tableDataSet.Table1);
            label7.Text = "Saved Done (:";
            //far3naHotelSystemBindingSource.EndEdit();
            //far3naHotelSystemTableAdapter.Update(far3na_HotelDataSet1.Far3na_Hotel_System);

        }

        private void button3_Click(object sender, EventArgs e)
        {
        MessageBox.Show(" Successe Deleted", "Deleted Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            table1BindingSource.RemoveCurrent();
            
        }
        /*                                                                                                    RRRRRRRRRRRRRRRRRRRRRRRR                                                                                               
                                                                                                                RRRRRRR................RRR                
                                                                                                                RRRRRRRR................RRRR                                                    
                                                                                            AAA                 RRRRRRRR.................RRRR                                           
          OOOOOOOOOOOO                  MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                AAAAA                R....RRR................RRRRR
       OOOO...........OOO               MMMMMMMM ..................MMMMMMMM               AAAAAAA               RRRRRR.................RRRRRR
     OOO................OOO             M......MMM...............MMM......M              AAAAAAAAA              R....RR...............RRRRRRR
    OOOO.................OOOO           M......M MM.............MM M......M             AAAA...AAAA             R....RR.............RRRRRRRR                       
   OOOOO..................OOOO          M......M  MM...........MM  M......M            AAAAA...AAAAA            R....RRRRRRRRRRRRRRRRRRRRR                 
    OOOOO.................OOOO          M......M   MM.........MM   M......M           AAAAAAAAAAAAAAA           R....RRR....RR....RRR....R          
     OOOO.................OOO           M......M    MM.......MM    M......M          AAAAAAAAAAAAAAAAA          R....R              R....R       
      OOOOO............OOOOO            M......M     MM.....MM     M......M         AAAAA.........AAAAA         R....R              R....R                                              
       OOOO............OOOO             M......M      MM...MM      M......M        AAAAA...........AAAAA        R....R              R....R
         OOOOOOOOOOOOOOO                M......M     MMMMMMMMM     M......M       AAAAA.............AAAAA       R....R              R....R
                                                                                AAAAAAAAAA........AAAAAAAAA    RRRRRRRR           RRRRRRRRR   
                                                                                                                
         */
        private void button4_Click(object sender, EventArgs e)
        {
            Godbye godbye = new Godbye();
          //  godbye.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveLast();
        }
        /*                                                                                                    RRRRRRRRRRRRRRRRRRRRRRRR                                                                                               
                                                                                                                RRRRRRR................RRR                
                                                                                                                RRRRRRRR................RRRR                                                    
                                                                                            AAA                 RRRRRRRR.................RRRR                                           
          OOOOOOOOOOOO                  MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                AAAAA                R....RRR................RRRRR
       OOOO...........OOO               MMMMMMMM ..................MMMMMMMM               AAAAAAA               RRRRRR.................RRRRRR
     OOO................OOO             M......MMM...............MMM......M              AAAAAAAAA              R....RR...............RRRRRRR
    OOOO.................OOOO           M......M MM.............MM M......M             AAAA...AAAA             R....RR.............RRRRRRRR                       
   OOOOO..................OOOO          M......M  MM...........MM  M......M            AAAAA...AAAAA            R....RRRRRRRRRRRRRRRRRRRRR                 
    OOOOO.................OOOO          M......M   MM.........MM   M......M           AAAAAAAAAAAAAAA           R....RRR....RR....RRR....R          
     OOOO.................OOO           M......M    MM.......MM    M......M          AAAAAAAAAAAAAAAAA          R....R              R....R       
      OOOOO............OOOOO            M......M     MM.....MM     M......M         AAAAA.........AAAAA         R....R              R....R                                              
       OOOO............OOOO             M......M      MM...MM      M......M        AAAAA...........AAAAA        R....R              R....R
         OOOOOOOOOOOOOOO                M......M     MMMMMMMMM     M......M       AAAAA.............AAAAA       R....R              R....R
                                                                                AAAAAAAAAA........AAAAAAAAA    RRRRRRRR           RRRRRRRRR   
                                                                                                                
         */
        private void button6_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            table1BindingSource.MovePrevious();
        }




        // private void label2_Click(object sender, EventArgs e)
        // {

        // }


        // //Insert btn
        // private void button1_Click(object sender, EventArgs e)
        // {
        //     if (NameTxt.Text != string.Empty && IDTxt.Text != string.Empty)
        //     {
        //         cmd = new SqlCommand("insert into Vis values (@id,@name,@gender,@date)", con);
        //         con.Open();
        //         cmd.Parameters.AddWithValue("@id", int.Parse(IDTxt.Text));
        //         cmd.Parameters.AddWithValue("@name", NameTxt.Text);
        //         if(MaleRb.Checked)
        //             cmd.Parameters.AddWithValue("@gender", "Male");
        //         else if(FemaleRb.Checked)
        //             cmd.Parameters.AddWithValue("@gender", "Female");
        //         cmd.Parameters.AddWithValue("@date",DateTime.Parse(dateTimePicker1.Text));
        ////         cmd.ExecuteNonQuery();
        //         con.Close();
        //         MessageBox.Show("Record Inserted Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //     }
        //     else
        //     {
        //         MessageBox.Show("Please Provide Details!","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //     }

        // }

        // //Display btn
        // private void button4_Click(object sender, EventArgs e)
        // {
        //     //con.Open();
        //     //DataTable dt = new DataTable();
        //     //adapt = new SqlDataAdapter("select * from Students_Tb", con);
        //     //adapt.Fill(dt);
        //     //dataGridView1.DataSource = dt;
        //     //con.Close();

        //     con.Open();
        //     cmd = new SqlCommand("select * from Vis", con);
        //     adapt = new SqlDataAdapter(cmd);
        //     DataTable dt = new DataTable();
        //     adapt.Fill(dt);
        //     dataGridView1.DataSource = dt;
        //     con.Close();
        // }


        // //Update btn
        // private void button2_Click(object sender, EventArgs e)
        // {
        //     if (NameTxt.Text != string.Empty && IDTxt.Text != string.Empty)
        //     {
        //         cmd = new SqlCommand("update Vis set Name=@name,gender=@gender,date=@date where ID=@id", con);
        //         con.Open();
        //         cmd.Parameters.AddWithValue("@id", int.Parse(IDTxt.Text));
        //         cmd.Parameters.AddWithValue("@name", NameTxt.Text);
        //         if (MaleRb.Checked)
        //             cmd.Parameters.AddWithValue("@gender", "Male");
        //         else if (FemaleRb.Checked)
        //             cmd.Parameters.AddWithValue("@gender", "Female");
        //         cmd.Parameters.AddWithValue("@date", DateTime.Parse(dateTimePicker1.Text));
        //       //  cmd.ExecuteNonQuery();
        //         con.Close();
        //         MessageBox.Show("Record Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //     }
        //     else
        //     {
        //         MessageBox.Show("Please Select Record to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //     }
        // }

        // //Delete btn
        // private void button3_Click(object sender, EventArgs e)
        // {
        //     int ID = int.Parse(IDTxt.Text);
        //     if (ID != 0)
        //     {
        //         cmd = new SqlCommand("delete Students_Tb where ID=@id", con);
        //         con.Open();
        //         cmd.Parameters.AddWithValue("@id", ID);
        //         cmd.ExecuteNonQuery();
        //         con.Close();
        //         MessageBox.Show("Record Deleted Successfully!","Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //     }
        //     else
        //     {
        //         MessageBox.Show("Please Select Record to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //     }

        // }

        // private void button5_Click(object sender, EventArgs e)
        // {
        //     IDTxt.Clear();
        //     NameTxt.Clear();
        //     MaleRb.Checked = false;
        //     FemaleRb.Checked = false;

        // }

        //search btn
        //private void button6_Click(object sender, EventArgs e)
        //{
        //    if (NameTxt.Text != string.Empty)
        //    {
        //        cmd = new SqlCommand("select * from Students_Tb where name like '%" + NameTxt.Text + "%'", con);
        //        con.Open();
        //        adapt = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adapt.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //        con.Close();
        //        MessageBox.Show("Record Retrieved Successfully!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Select Record to Search", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void IDTxt_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void NameTxt_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'far3na_HotelDataSet.Far3na_Hotel_System' table. You can move, or remove it, as needed.
        //    this.far3na_Hotel_SystemTableAdapter.Fill(this.far3na_HotelDataSet.Far3na_Hotel_System);

        //}
    }
}
