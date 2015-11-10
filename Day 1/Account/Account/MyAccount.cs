using System;
using System.CodeDom;
using System.Runtime.CompilerServices;

namespace Account
{
	public class MyAccount
	{
		public IAccountRepo Repo { get; set; }

		public int Balance
		{
			get { return Repo.Balance; }
		}

		public MyAccount()
		{
			//IoCContainer.Register<ILogger>(new DBLogger());
			//IoCContainer.Register<ILogger>(new ConsoleLogger(),"console");

			//var logger = IoCContainer.Resolve<ILogger>();
		}

		#region Peel
		//public MyAccount(IAccountRepo repo)
  //      {
	 //       SomeStaticDependency.DoSomething();
	 //       Init(repo);
  //      }

		//internal void Init(IAccountRepo repo)
		//{
		//	Repo = repo;
		//	//GetDependency();
		//	Repo.Balance = 100;
		//}
		#endregion

		#region Slice

		public MyAccount(IAccountRepo repo)
			:this (repo, SomeStaticDependency.DoSomething)
		{
			
		}

		//Delegate to slice out code in the middle
		public MyAccount(IAccountRepo repo, Func<string> GetDependency)
		{
			Repo = repo;
			GetDependency();
			Repo.Balance = 100;
		}

		#endregion

		public decimal Deposit(int depositAmount)
		{
			return Repo.Deposit(depositAmount);
		}

		public decimal Withdraw(int withdrawAmount)
		{
			return Repo.Withdraw(withdrawAmount);
		}
	}

	internal static class SomeStaticDependency
	{
		public static string DoSomething()
		{
			return "Some String";
		}
	}
}
