using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enco.Core.Models
{
    public abstract class BaseEntity
    {
        
        public int Id { get;  set; }
    }
}