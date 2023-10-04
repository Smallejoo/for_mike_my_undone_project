using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Properties
{
    public class pawn : basic_piece
    {
        public override string who_am_i()
        {
            return "pawn";
        }
        public override void move_piece(basic_piece from, basic_piece to_where)
        {

        }
       
        public pawn(ChessColor its_color, Cordinates its_position) :base(its_color,its_position)
        {
        }
        public override void leagel_moves(basic_piece the_one, board curr_board)
        {
            Cordinates cur_pos = the_one.position;
            if(the_one.color==basic_piece.ChessColor.white && cur_pos.x + 1 <8)
            {
            basic_piece the_piece_moves = curr_board.GetFigureAt(cur_pos.x+1, cur_pos.y);//the place we can go
            basic_piece.ChessColor our_team = curr_board.GetFigureAt(cur_pos.x, cur_pos.y).color;
              if ("blank" == curr_board.GetFigureAt(cur_pos.x+1, (cur_pos.y)).who_am_i() && cur_pos.x + 1 < 9)//if its blank there
            {
                curr_board.GetFigureAt(cur_pos.x+1, cur_pos.y).Mcolor=basic_piece.ChessMoveColor.green;
                //paint it green so we will be able to go there
            }
            
            if ((our_team != the_piece_moves.color&&the_piece_moves.who_am_i()!="blank"&&cur_pos.x+1<9))
            {
               
                curr_board.GetFigureAt(cur_pos.x+1, cur_pos.y).Mcolor = basic_piece.ChessMoveColor.attack;
                // if it some ones paint it orange 
            }

            }
            else if( cur_pos.x - 1 >=0 )
            {

                basic_piece the_piece_moves = curr_board.GetFigureAt(cur_pos.x - 1, cur_pos.y);//the place we can go
                basic_piece.ChessColor our_team = curr_board.GetFigureAt(cur_pos.x, cur_pos.y).color;
                if ("blank" == curr_board.GetFigureAt(cur_pos.x -1, (cur_pos.y)).who_am_i())//if its blank there
                {
                    curr_board.GetFigureAt(cur_pos.x - 1, cur_pos.y).Mcolor = basic_piece.ChessMoveColor.green;
                    //paint it green so we will be able to go there
                }

                if (our_team != the_piece_moves.color)
                {
                    curr_board.GetFigureAt(cur_pos.x-1, cur_pos.y).Mcolor = basic_piece.ChessMoveColor.attack;
                    // if it some ones paint it orange 
                }
            }
                
            
            
           

            
        }



    }
    public class blank:basic_piece
    {
        public blank(ChessColor its_color,Cordinates its_cords) :base(its_color,its_cords)
        {

        }
        public override string who_am_i()
        {
            return "blank";

        }
       
        public override void move_piece(basic_piece from, basic_piece to_where)
        {
         
        }
    }
    

}
