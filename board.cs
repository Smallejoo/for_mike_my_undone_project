using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Properties
{
    public class board
    {
        private basic_piece[,] boardState;

        public board()
        {
            boardState = new basic_piece[8, 8];
           
            InitializeBoard();
        }
        public basic_piece GetFigureAt(int row, int col)
        {
            return boardState[row, col];
        }

        public void InitializeBoard()
        {
             int b = 0;
            for(int r=0;r<8;r++)
            {
                for(int c=0;c<8;c++ )
                 {
                    Cordinates pos=new Cordinates(r,c);
                    if(b==0)
                    {
                    boardState[r, c] = new blank(basic_piece.ChessColor.white,pos);
                        b++;
                    }
                    if(b==1)
                    {
                       boardState[r, c] = new blank(basic_piece.ChessColor.black, pos);
                        b = 0;
                    }


                }
            }
            for (int r = 1; r < 2; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    boardState[r, c] = new pawn(basic_piece.ChessColor.white, boardState[r, c].position);
                }
            }
            for (int r = 7; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    boardState[r, c] = new pawn(basic_piece.ChessColor.black, boardState[r, c].position);
                }
            }
            boardState[5, 5] = new king(basic_piece.ChessColor.black, boardState[5, 5].position);
            boardState[5, 6] = new Knight(basic_piece.ChessColor.black, boardState[5, 6].position);
        }
        public  basic_piece move_piece_board(basic_piece move_this,basic_piece to_here)
        {
            if(to_here!=null)
            {
            Cordinates start = move_this.position;
            Cordinates end = to_here.position;
                boardState[end.x, end.y] = move_this;
                boardState[start.x, start.y] = new blank(move_this.color, start);
                boardState[end.x, end.y].position = end;
                return (boardState[end.x, end.y]);




            }
            if(to_here==null||to_here.who_am_i()=="blank")
            {
                Cordinates start = move_this.position;
                Cordinates end = to_here.position;
                boardState[end.x, end.y] = move_this;
                boardState[start.x, start.y] = new blank(move_this.color, start);
                boardState[end.x, end.y].position = end;
                return (boardState[end.x, end.y]);
            }
            return null;

        }


       
    }
}
