namespace Account
{
	public interface IAccountRepo
	{
		decimal Deposit(int depositAmount);
		decimal Withdraw(int withdrawAmount);
		int Balance { get; set; }
	}
}