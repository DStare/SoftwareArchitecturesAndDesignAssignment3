using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal abstract class PaymentMethod
    {
        public abstract void showGUI();
        public abstract void processPayment(float totalPrice);
        public abstract void verifyPayment();

        public abstract bool getIsValidPaymentDetails { get; }

    }
}
