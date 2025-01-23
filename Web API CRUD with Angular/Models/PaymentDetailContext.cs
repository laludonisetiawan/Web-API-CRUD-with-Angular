using Microsoft.EntityFrameworkCore;

namespace Web_API_CRUD_with_Angular.Models
{
    public class PaymentDetailContext : DbContext
    {
        // constuctor untuk paymentDetailContext
        public PaymentDetailContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; } // konek ke Model PaymentDetail
    }
}
