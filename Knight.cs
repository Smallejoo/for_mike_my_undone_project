using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.Properties
{
    internal class Knight : basic_piece
    {



        public Knight(ChessColor its_collor, Cordinates its_pos, ChessMoveColor its_move_collor = ChessMoveColor.none) : base(its_collor, its_pos)
        {
            this.Mcolor = its_move_collor;
            this.move_count_x = 1;
            this.move_count_y = 2;


        }


        public override string who_am_i()
        {
            return "Knight";

        }



     

    }

}
