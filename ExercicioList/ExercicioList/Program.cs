using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioList {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos funcionarios voce gostaria de acrescentar?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++){
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Informe o id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Informe o nome: ");
                string name = Console.ReadLine();
                Console.Write("Informe o Salario: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Informe o ID do funcionario que tera aumento: ");
            int funcId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == funcId);
            if (emp != null) {
                Console.Write("Informe a %: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
               
            }
            else {
                Console.Write("Id nao existe, nada sera feito");
            }

            Console.WriteLine("Dados dos funcionarios: ");
            //list é padrao
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
