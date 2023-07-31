using ChessChallenge.API;
using System.Diagnostics;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves();
        Debug.WriteLine(moves);
        System.Random rand = new();
        return moves[rand.Next(moves.Length)];
    }
}