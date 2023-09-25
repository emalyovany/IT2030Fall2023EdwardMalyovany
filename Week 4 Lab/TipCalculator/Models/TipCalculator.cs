using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a value for cost of meal.")]
        [Range(0.0, 10000000.0, ErrorMessage = "Cost of meal must be greater than zero.")]
        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {
            if (MealCost.HasValue)
            {
                // Issue: Missing a semicolon at the end of the line.
                var tip = MealCost.Value / percent;
                return tip; // Fix: Added the missing semicolon.
            }
            else
            {
                return 0;
            }
        }
    }
}
