using ChessChallenge.API;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves();

        System.Random rand = new();
        return moves[rand.Next(moves.Length)];
    }
}