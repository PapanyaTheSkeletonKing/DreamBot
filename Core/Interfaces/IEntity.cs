using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}