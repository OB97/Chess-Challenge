using ChessChallenge.API;
using System.Diagnostics;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves();
        Debug.WriteLine(moves[0]);

        System.Random rand = new();
        return moves[rand.Next(moves.Length)];
    }
}