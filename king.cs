using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Properties
{
    class king : basic_piece
    {
        public king(ChessColor its_color, Cordinates its_cords, ChessMoveColor color_move=ChessMoveColor.none):base(its_color,its_cords)
        {
            this.Mcolor = color_move;

        }
        public override string who_am_i()
        {
            return"king";
        }
        public override void leagel_moves(basic_piece the_one, board current_board)
        {
            int row, col;
            row = the_one.position.x;
            col = the_one.position.y;
            if (row + 1 < 8)
            {
                if (((basic_piece)current_board.GetFigureAt(row + 1, col)).who_am_i() == "blank")
                {
                    ((basic_piece)current_board.GetFigureAt(row + 1, col)).Mcolor = basic_piece.ChessMoveColor.green;
              
                }
                else if (the_one.color != current_board.GetFigureAt(row + 1, col ).color)
                {
                    current_board.GetFigureAt(row + 1, col).Mcolor = ChessMoveColor.attack;
                }
                
                

                
            }
            if (row - 1 >= 0)
            {
                if (((basic_piece)current_board.GetFigureAt(row - 1, col)).who_am_i() == "blank")
                {
                    ((basic_piece)current_board.GetFigureAt(row - 1, col)).Mcolor = basic_piece.ChessMoveColor.green;
                }
                else if(the_one.color != current_board.GetFigureAt(row - 1, col ).color)
                {
                    current_board.GetFigureAt(row - 1, col-1).Mcolor = ChessMoveColor.attack;
                }
            }
            if (col + 1 < 8)
            {
                if (((basic_piece)current_board.GetFigureAt(row, col + 1)).who_am_i() == "blank")
                {
                    ((basic_piece)current_board.GetFigureAt(row, col + 1)).Mcolor = basic_piece.ChessMoveColor.green;
                }
                else if(the_one.color != current_board.GetFigureAt(row, col + 1).color)
                {
                    current_board.GetFigureAt(row + 1, col+1).Mcolor = ChessMoveColor.attack;
                }
            }
            if (col - 1 >= 0)
            {
                if (((basic_piece)current_board.GetFigureAt(row, col - 1)).who_am_i() == "blank")
                {
                    ((basic_piece)current_board.GetFigureAt(row, col - 1)).Mcolor = basic_piece.ChessMoveColor.green;
                }
                else if(the_one.color != current_board.GetFigureAt(row, col - 1).color)
                {
                    current_board.GetFigureAt(row -1, col-1).Mcolor = ChessMoveColor.attack;
                }
            }
            if (row + 1 < 8 && col + 1 < 8)
            {
                if (((basic_piece)current_board.GetFigureAt(row + 1, col + 1)).who_am_i() == "blank")
                {
                    ((basic_piece)current_board.GetFigureAt(row + 1, col + 1)).Mcolor = basic_piece.ChessMoveColor.green;
                }
                else if(the_one.color != current_board.GetFigureAt(row + 1, col + 1).color)
                {
                    current_board.GetFigureAt(row + 1, col+1).Mcolor = ChessMoveColor.attack;
                }
            }
            if (row - 1 >= 0 && col - 1 >= 0)
            {
                if (((basic_piece)current_board.GetFigureAt(row - 1, col - 1)).who_am_i() == "blank")
                {
                    ((basic_piece)current_board.GetFigureAt(row - 1, col - 1)).Mcolor = basic_piece.ChessMoveColor.green;
                }
                else if(the_one.color != current_board.GetFigureAt(row - 1, col - 1).color)
                {
                    current_board.GetFigureAt(row - 1, col-1).Mcolor = ChessMoveColor.attack;
                }
            }
            if (row + 1 < 8 && col - 1 >= 0)
            {
                if (((basic_piece)current_board.GetFigureAt(row + 1, col - 1)).who_am_i() == "blank")
                {
                    ((basic_piece)current_board.GetFigureAt(row + 1, col - 1)).Mcolor = basic_piece.ChessMoveColor.green;
                }
                else if(the_one.color != current_board.GetFigureAt(row + 1, col + 1).color)
                {
                    current_board.GetFigureAt(row + 1, col-1).Mcolor = ChessMoveColor.attack;
                }
            }
            if (row - 1 >= 0 && col + 1 < 8)
            {
                if (((basic_piece)current_board.GetFigureAt(row - 1, col + 1)).who_am_i() == "blank")
                {
                    ((basic_piece)current_board.GetFigureAt(row - 1, col + 1)).Mcolor = basic_piece.ChessMoveColor.green;
                }
                else if(the_one.color != current_board.GetFigureAt(row - 1, col + 1).color)
                {
                    current_board.GetFigureAt(row - 1, col+1).Mcolor = ChessMoveColor.attack;
                }
            }
        }

    }
}
