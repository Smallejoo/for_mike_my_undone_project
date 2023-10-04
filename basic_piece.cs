using System;    
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Properties
{
    public abstract class basic_piece
    {

        public enum ChessColor { black, white, blank }
        public enum ChessMoveColor { green, attack, none }
        public int move_count_x;
        public int move_count_y;
        public int border_top = 8;
        public int border_bottom = -1;
        public virtual string who_am_i()
        {
            return "E";
        }
        /*
        public virtual void leagel_moves(basic_piece the_one, board current_board)
        {
            int extra_move = 0;
            Cordinates pos = the_one.position;
            if(the_one.who_am_i()=="king"||the_one.who_am_i()== "Knight")
            {
                extra_move = 1;
            }
            

            if( (pos.x + move_count_x < 8 && pos.y + move_count_y < 8)&&current_board.GetFigureAt(pos.x+move_count_x, pos.y+move_count_y).who_am_i()=="blank")
            {
                current_board.GetFigureAt(pos.x + move_count_x, pos.y + move_count_y).Mcolor = ChessMoveColor.green;
            }
            else if ((pos.x + move_count_x < 8 && pos.y + move_count_y < 8)&& current_board.GetFigureAt(pos.x + move_count_x, pos.y + move_count_y).color != the_one.color)
           {
                current_board.GetFigureAt(pos.x + move_count_x, pos.y + move_count_y).Mcolor = ChessMoveColor.attack;
           }


            if ((pos.x + move_count_x < 8 && pos.y - move_count_y > -1)&&current_board.GetFigureAt(pos.x + move_count_x, pos.y - move_count_y).who_am_i() == "blank" )
            {
                current_board.GetFigureAt(pos.x + move_count_x, pos.y - move_count_y).Mcolor = ChessMoveColor.green;
            }
            else if ((pos.x + move_count_x < 8 && pos.y - move_count_y > -1)&& current_board.GetFigureAt(pos.x + move_count_x, pos.y - move_count_y).color!=the_one.color)
            {
                current_board.GetFigureAt(pos.x + move_count_x, pos.y - move_count_y).Mcolor = ChessMoveColor.attack;


            }
            
            

            if ((pos.x + move_count_x > -1 && pos.y + move_count_y < 8)&&current_board.GetFigureAt(pos.x - move_count_x, pos.y + move_count_y).who_am_i() == "blank" )
            {
                current_board.GetFigureAt(pos.x - move_count_x, pos.y + move_count_y).Mcolor = ChessMoveColor.green;
            }
            else if ((pos.x + move_count_x > -1 && pos.y + move_count_y < 8) && current_board.GetFigureAt(pos.x - move_count_x, pos.y + move_count_y).color!=the_one.color)
            {

                current_board.GetFigureAt(pos.x - move_count_x, pos.y + move_count_y).Mcolor = ChessMoveColor.attack;

            }

            if ((pos.x + move_count_x > -1 && pos.y + move_count_y > -1) && current_board.GetFigureAt(pos.x - move_count_x, pos.y - move_count_y).who_am_i() == "blank"  )
            {
                current_board.GetFigureAt(pos.x - move_count_x, pos.y - move_count_y).Mcolor = ChessMoveColor.green;
            }

            else if((pos.x + move_count_x > -1 && pos.y + move_count_y > -1) && current_board.GetFigureAt(pos.x - move_count_x, pos.y - move_count_y).color!=the_one.color)
            {
                current_board.GetFigureAt(pos.x - move_count_x, pos.y - move_count_y).Mcolor = ChessMoveColor.attack;
            }

            if(extra_move==1)
            {
                int temp = move_count_x;
                move_count_x = move_count_y;
                move_count_y = temp;
                

                if ((pos.x + move_count_x < 8 && pos.y + move_count_y < 8)&& current_board.GetFigureAt(pos.x + move_count_x, pos.y + move_count_y).who_am_i() == "blank"  )
                {
                    current_board.GetFigureAt(pos.x + move_count_x, pos.y + move_count_y).Mcolor = ChessMoveColor.green;
                }
                else if ((pos.x + move_count_x < 8 && pos.y + move_count_y < 8) && current_board.GetFigureAt(pos.x + move_count_x, pos.y + move_count_y).color!=the_one.color)

                {
                     current_board.GetFigureAt(pos.x + move_count_x, pos.y + move_count_y).Mcolor = ChessMoveColor.attack;

                }
                if ((pos.x + move_count_x < 8 && pos.y + move_count_y > -1)&& current_board.GetFigureAt(pos.x + move_count_x, pos.y - move_count_y).who_am_i() == "blank"  )
                {
                    current_board.GetFigureAt(pos.x + move_count_x, pos.y - move_count_y).Mcolor = ChessMoveColor.green;
                }
                else if ((pos.x + move_count_x < 8 && pos.y + move_count_y > -1) && current_board.GetFigureAt(pos.x + move_count_x, pos.y - move_count_y).color!=the_one.color)
                {
                   current_board.GetFigureAt(pos.x + move_count_x, pos.y - move_count_y).Mcolor = ChessMoveColor.attack;
                }
                if ((pos.x + move_count_x > -1 && pos.y + move_count_y < 8)&& current_board.GetFigureAt(pos.x - move_count_x, pos.y + move_count_y).who_am_i() == "blank"  )
                {
                    current_board.GetFigureAt(pos.x - move_count_x, pos.y + move_count_y).Mcolor = ChessMoveColor.green;
                }
                else if((pos.x + move_count_x > -1 && pos.y + move_count_y < 8) && current_board.GetFigureAt(pos.x - move_count_x, pos.y + move_count_y).color!=the_one.color)
                {
                   current_board.GetFigureAt(pos.x - move_count_x, pos.y + move_count_y).Mcolor = ChessMoveColor.attack;
                }

                if ((pos.x + move_count_x > -1 && pos.y + move_count_y > -1)&& current_board.GetFigureAt(pos.x - move_count_x, pos.y - move_count_y).who_am_i() == "blank" )
                {
                    current_board.GetFigureAt(pos.x - move_count_x, pos.y - move_count_y).Mcolor = ChessMoveColor.green;
                }
                else if ((pos.x + move_count_x > -1 && pos.y + move_count_y > -1) && current_board.GetFigureAt(pos.x - move_count_x, pos.y - move_count_y).color!=the_one.color)
                {
                    current_board.GetFigureAt(pos.x - move_count_x, pos.y - move_count_y).Mcolor = ChessMoveColor.attack;
                }







            }


        }
        */
        public virtual void leagel_moves(basic_piece the_one, board current_board)

        {
            
            int extra_move = 0;
            int[] move_multypli_x_all = { 1, 0, 1, -1, 1, -1, 0, -1 };
            int[] move_multypli_y_all = { 1, 1, 0, 1, -1, -1, -1, 0 };
            int[] move_multy_x_straight = { 0, 1, 0, -1 };
            int[] move_multy_y_straight = { 1, 0, -1, 0 };
            int[] move_multy_x_digonal = { 1, -1, -1, 1 };
            int[] move_multy_y_digonal = { 1, 1, -1, -1 };
            int move_count_x = 0;
            int move_count_y = 0;
            int[] used_multy_x = null;
            int[] used_multy_y = null;
            Cordinates pos = the_one.position;
            if (the_one.who_am_i() == "king" || the_one.who_am_i() == "Knight") // how much moves to give the piece 
            {
                extra_move = 1;
            }
            if (extra_move == 1)
            {
                int i = 8;
            }
            else
            {
                int i = 4;
            }
            if (the_one.who_am_i() == "king" || the_one.who_am_i() == "knight")   // the pices who got more then 4 moves
            {


                used_multy_x = move_multypli_x_all;

                used_multy_y = move_multypli_y_all;
            }
            else if (the_one.who_am_i() == null)       // 4 moves 
            {
                used_multy_x = move_multy_x_digonal;
                used_multy_y = move_multy_y_digonal;
            }
            else if (the_one.who_am_i() == null)
            {
                used_multy_x = move_multy_x_straight;
                used_multy_y = move_multy_y_straight;
            }
            for (int index = 0; index < index; index++) // calculating the posible moves in a loop 
            {
                if ((((used_multy_x[index]) * move_count_x) + the_one.position.x) > -1 && ((used_multy_x[index] * move_count_x) + the_one.position.x) < 8)
                {//the if is cheaking if i am inside the bourd and its leagel to move there 

                    int pos_move_x = ((used_multy_x[index] * move_count_x) + the_one.position.x);
                    int pos_move_y = ((used_multy_x[index] * move_count_x) + the_one.position.x);
                    // calculating the direction * how much should it move 
                    // and then we add it to the figure we choose 
                    basic_piece move_location_fig = current_board.GetFigureAt(pos_move_x, pos_move_y);
                    if (move_location_fig.who_am_i() == "blank")
                    {
                        move_location_fig.Mcolor = basic_piece.ChessMoveColor.green;//deside what to do with the space 
                                                                                    // if its blank we can move 
                    }
                    else if (the_one.color != move_location_fig.color) // if its the opsite collor we can eat the piece 
                    {
                        move_location_fig.Mcolor = basic_piece.ChessMoveColor.attack;
                    }




                }




            }
        }








        public virtual void move_piece(basic_piece from, basic_piece to_where)
        {

        }
        public ChessColor color { set; get; }
        public ChessMoveColor Mcolor { set; get; }

        public Cordinates position { set; get; }
        public basic_piece(ChessColor its_color, Cordinates its_position)
        {
            this.color = its_color;
            this.position = its_position;
            this.Mcolor = basic_piece.ChessMoveColor.none;


        }
        public int Storage { set; get; }




    }
}