using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        Button[,] buttons_array = new Button[8, 8];
        board the_board = new board();
        //Button prev_button;
        Cordinates prev_button_pos;
        int clicked_choose = 0;
        public void createButtons()
        {
            int buttsize = 50;
            int xOS = 50;
            int YOS = 50;
            for (int row=0;row<8;row++)
            {
                for(int col=0;col<8;col++)
                {
                    Button button = new Button();
                    button.Size = new Size(buttsize, buttsize);
                    button.Location = new Point(xOS + col * buttsize, YOS + row * buttsize);
                    button.Click += Button_Click;
                    button.Tag = the_board.GetFigureAt(row,col);
                    basic_piece its = (basic_piece)button.Tag;
                    string it_is=its.who_am_i();
                    if(it_is=="blank")
                    {

                    }
                    else
                    {
                        button.Text = it_is;
                    }

                    this.Controls.Add(button);
                    buttons_array[row, col] = button;

                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button the_click_now = (Button)sender;

           
            if(clicked_choose==0)   //first time click                                                                // FIRST FIGURE TO SELECT
            {
            if(((basic_piece)the_click_now.Tag).who_am_i()=="blank")
                {
                    return;
                }
            the_click_now.BackColor = Color.Yellow;
                clicked_choose = 1;
                // now we need to color the moves of this figure
                ((basic_piece)the_click_now.Tag).leagel_moves((basic_piece)the_click_now.Tag,the_board);




                prev_button_pos = ((basic_piece)the_click_now.Tag).position;
                refresh_only_color();
                
                refresh_but_tags();

                
            }
            else if(clicked_choose==1)  //same place un yello                                                //WE ALREADY SELECTED A FIGURE
            {
                Button prev_button = buttons_array[prev_button_pos.x, prev_button_pos.y];
                basic_piece prev_piece = ((basic_piece)prev_button.Tag);
                basic_piece curr_piece = (basic_piece)the_click_now.Tag;
                if(the_click_now.BackColor == Color.Yellow)                                         //SAME FIGURE SO UN YELLOW
                {
                   
                    if(curr_piece.position == prev_piece.position )

                    {
                    the_click_now.BackColor = Color.White;
                    clicked_choose = 0;
                    prev_button_pos = null;
                        refresh_only_color();
                        refresh_but_tags();
                        //refresh_but_tags();
                    return;
                    }
                }
                
                if(curr_piece.position!=prev_piece.position&&"blank"!=prev_piece.who_am_i()&&(curr_piece.Mcolor==basic_piece.ChessMoveColor.green|| curr_piece.Mcolor == basic_piece.ChessMoveColor.attack))                        // IF ITS NOT THE SAME ONE 
                {
                    refresh_only_color();
                    buttons_array[prev_button_pos.x,prev_button_pos.y].BackColor = Color.White;
                    the_click_now.Tag = prev_button.Tag;  
                    string it_is =prev_piece.who_am_i();
                    if (it_is != "blank")
                        the_click_now.Text = it_is;
                    //prev_button.Tag = new blank(((basic_piece)prev_button.Tag).color,((basic_piece)prev_button.Tag).position);
                    prev_button.Text = "";
                    clicked_choose = 0;
                        basic_piece prev_should_tag_this=the_board.move_piece_board(prev_piece, curr_piece); // here i am letting the prevv button to tag the blank space
                    prev_button.Tag = prev_should_tag_this;

                    //prev_button = null;
                    refresh_but_tags();
                    refresh_only_color() ;
                    
                    return;
                }
                if("blank" == prev_piece.who_am_i())
                {
                    refresh_but_tags();
                    refresh_only_color();
                    return;
                }    


            }
            
        }
        public void refresh_only_color()
        {
            for (int row = 0; row < 8; row++) // colloring efter a move back 
            {
                for (int col = 0; col < 8; col++)
                {
                    basic_piece correction = the_board.GetFigureAt(row, col);                   // coloring back 
                   
                    if (correction.Mcolor == basic_piece.ChessMoveColor.green&&clicked_choose==0)
                    {
                        buttons_array[row, col].BackColor = Color.White;
                        correction.Mcolor = basic_piece.ChessMoveColor.none;
                    }
                    else if (correction.Mcolor == basic_piece.ChessMoveColor.attack && clicked_choose == 0)
                    {
                        buttons_array[row, col].BackColor = Color.White;
                        correction.Mcolor = basic_piece.ChessMoveColor.none;
                    }

                }
            }
        }

    

        public void refresh_but_tags()
        {
            for (int row=0; row<8; row++)
            {
                for(int col=0; col<8; col++)
                {
                    basic_piece correction = the_board.GetFigureAt(row, col);
                    buttons_array[row, col].Tag = correction;

                }
            }//just to refreshh all 
            for (int row = 0; row < 8; row++) // collor the moves if needed 
            {
                for (int col = 0; col < 8; col++)
                {
                    basic_piece correction = the_board.GetFigureAt(row, col);                   // colloring the moves 
                    if (correction.Mcolor == basic_piece.ChessMoveColor.green&&clicked_choose==1)
                    {
                        buttons_array[row, col].BackColor = Color.Green;
                    }
                    else if(correction.Mcolor == basic_piece.ChessMoveColor.attack)
                    {
                        buttons_array[row, col].BackColor = Color.Orange;
                    }

                }
            }
        }
        public Form1()
        {
            the_board.InitializeBoard();
            createButtons();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
