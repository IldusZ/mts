using System.Data.Entity;

namespace MTSTask.Models
{
    /// <summary>
    /// Контекст данных, используемый для взаимодействия с базой данных
    /// </summary>
    public class CRMContext : DbContext
    {
        /// <summary>
        /// Информация о телефонных вызовах
        /// </summary>
        public DbSet<CallEvent> CallEvents { get; set; }
    }
}