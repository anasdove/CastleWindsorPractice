namespace CastleWindsorPractice.Domain
{
    public interface IMemberRepository
    {
        void Add(Member member);
        void Update(Member member);
    }
}