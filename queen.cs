using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    internal class queen :basic_piece
    {

        public queen(ChessColor its_color, Cordinates its_cords, ChessMoveColor color_move = ChessMoveColor.none) : base(its_color, its_cords)
        {
            this.Mcolor = color_move;
            move_count_x = 1;
            move_count_y = 1;

        }
        public override string who_am_i()
        {
            return "queen";
        }
        public override void leagel_moves(basic_piece the_one, board current_board)
        {
            string who_is_it=the_one.who_am_i();
            if(who_is_it=="queen")
            {

                for(int i=0,count_direct=0 ;i<4; i++)//straight lines 
                {
                    
                    while(move_count_x+the_one.position.x<8&&move_count_y- the_one.move_count_y>8)
                    {
                        basic_piece what_we_got;
                        what_we_got=current_board.GetFigureAt(move_count_x + the_one.position.x, move_count_y + the_one.position.y);
                        if(what_we_got.who_am_i()=="blank")
                        {
                            what_we_got.Mcolor = basic_piece.ChessMoveColor.green;
                        }
                        else if(what_we_got.color!=the_one.color)
                        {
                            what_we_got.Mcolor = basic_piece.ChessMoveColor.attack;
                        }
                        if (count_direct == 0)
                        move_count_x++;
                        else if(count_direct == 1)
                        {
                            move_count_x = 1;
                            move_count_y++;
                        }
                        if(count_direct == 2)
                        {
                            if(move_count_x>0)
                            {
                                move_count_x = -1;
                            }
                            move_count_x--; 
                            
                        }
                        if(count_direct == 3)
                        {
                            if(move_count_y>0)
                                move_count_y = -1;
                            move_count_x = -1;
                            move_count_y--; 

                        }

                    }
                    count_direct++; 

                }


            }
            else if(who_is_it=="fizer")
            {

            }
            else if(who_is_it=="tower")
            {

            }
        }
    }
}
