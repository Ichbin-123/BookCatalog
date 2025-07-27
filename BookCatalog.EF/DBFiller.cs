using BookCatalog.DAL;
using BookCatalog.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.EF;

public class DBFiller
{
    public static void Fill(BookContext dc)
    {
        if (dc.Book.Any())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BookCatalog DB is already initialized.");
            Console.ResetColor();
            return;
        }

        try
        {
            dc.Book.Add(new Book { Title = "C# 13 and .NET 9 – Modern Cross-Platform Development Fundamentals: Start building websites and services with ASP.NET Core 9, Blazor, and EF Core 9", Author = "Mark J. Price", Year = 2024 });
            dc.Book.Add(new Book { Title = "Python 4 and AI-Powered Development – Build Intelligent Applications with FastAPI, TensorFlow, and LangChain", Author = "Lisa M. Torres", Year = 2025 });
            dc.Book.Add(new Book { Title = "JavaScript 2025 and the Modern Web Stack – Master Full-Stack Web Development with Node.js 22, React 20, and Next.js", Author = "Derek H. Lang", Year = 2025 });
            dc.Book.Add(new Book { Title = "Rust for Cloud-Native Applications – Build Secure and Performant APIs with Axum, Tokio, and WebAssembly", Author = "Nina K. Bauer", Year = 2024 });
            dc.Book.Add(new Book { Title = "Go 1.22 and Scalable Backend Systems – Develop Fast Microservices with Gin, gRPC, and Kubernetes", Author = "Carlos Mendez", Year = 2025 });
            dc.Book.Add(new Book { Title = "Machine Learning Engineering with Python and MLOps – Deploy Scalable Models using MLflow, Airflow, and Azure ML", Author = "Sophia L. Kim", Year = 2024 });
            dc.Book.Add(new Book { Title = "C++ 23 and High-Performance Computing – Write Modern, Efficient Code for Games, Simulations, and Embedded Systems", Author = "Andrei Petrov", Year = 2025 });
            dc.Book.Add(new Book { Title = "Kotlin 2.0 and Android 15 Development – Build Modern Mobile Apps with Jetpack Compose and Firebase Integration", Author = "Julia R. Tanaka", Year = 2025 });
            dc.Book.Add(new Book { Title = "DevOps with Docker, Kubernetes, and GitHub Actions – Automate CI/CD Pipelines for Scalable Cloud Deployments", Author = "Ben J. Ortega", Year = 2024 });
            dc.Book.Add(new Book { Title = "Cybersecurity Fundamentals with Python – Build Secure Systems and Detect Threats using Nmap, Wireshark, and Scapy", Author = "Tariq E. Hassan", Year = 2024 });
            dc.Book.Add(new Book { Title = "Data Science in Practice – Analyze, Visualize, and Deploy Insights using Pandas, Power BI, and Streamlit", Author = "Emma D. Clarke", Year = 2025 });
            dc.Book.Add(new Book { Title = "La mia vita a Oggetti", Author = "Matteo Valenzi", Year = 2025 });
            dc.Book.Add(new Book { Title = "Mein Leben in Objekten", Author = "Matteo Valenzi", Year = 2026 });
            dc.Book.Add(new Book { Title = "My Object Oriented Life - An alternative view of existence", Author = "Matteo Valenzi", Year = 2025 });

            dc.SaveChanges();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All books were successfully loaded into the BookCatalog DB.");
            Console.ResetColor();
        }
        catch(Exception ex) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.InnerException?.Message);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DBFiller encountered a Problem. No book was uploaded into the BookCatalog DB.");
            Console.ResetColor();
        }
    }
}
