using System; 

namespace Polimorfismo {
  class Program {
    // MAIN 
    static void Main(string[] args){
      Console.WriteLine("Hello, World!"); } 

      
  }
  // BASE CLASS
  public abstract class BaseEmployee {
    public string Name { get; set; } 
    public int SNN { get; set; }
    public abstract decimal CalculateSalary();
  }

  // FIXED SALARY EMPLOYEE
  public abstract class FixedSalaryEmployee : BaseEmployee{
    public decimal Salary { get; set; }
    public double Perfomance { get; set; }

    protected int MinimumPerformance = 70;
    protected int BonusPerformance = 120;
    protected double BonusPercentage = 0.5; 
  }

  // FIXED SALARY PROFESSOR
  public class FixedSalaryProfessor : FixedSalaryEmployee{
    public override decimal CalculateSalary(){
      decimal FinalSalary;
      if (this.Perfomance < this.MinimumPerformance){
        FinalSalary = this.Salary / 2;
      } else if (Perfomance < this.BonusPerformance) {
	FinalSalary = this.Salary;
      } else {
	FinalSalary = Decimal.Multiply(this.Salary, 0.5M);
      }
      
      return FinalSalary;
    }

    public FixedSalaryProfessor(string name, int snn, decimal salary) {
      this.Name = name;
      this.SNN = snn;
      this.Salary = salary;
    }
  }

  // FIXED SALARY ADMIN
  public class FixedSalaryAdmin : FixedSalaryEmployee{
    public override decimal CalculateSalary(){
      decimal FinalSalary;
      if (this.Perfomance < this.MinimumPerformance){
        FinalSalary = this.Salary / 2;
      } else if (Perfomance < this.BonusPerformance) {
	FinalSalary = this.Salary;
      } else {
	FinalSalary = Decimal.Multiply(this.Salary, 0.5M);
      }
      
      return FinalSalary;
    }

    public FixedSalaryAdmin(string name, int snn, decimal salary) {
      this.Name = name;
      this.SNN = snn;
      this.Salary = salary;
    }
  }

  // HOURLY SALARY PROFESSOR
  public class HourlyProfessorEmployee : BaseEmployee{
    public decimal DefaultHourlyRate = 800.00M;
    public int Hours { get; set; }

    public void AddHour(){
      this.Hours++;
    }

    public override decimal CalculateSalary(){
      return Decimal.Multiply(DefaultHourlyRate, Hours);
    }
  }
}
