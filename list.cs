//MCCScript 1.0
for (int i = 1; i > 0; i++)
{
	Thread.Sleep(60000);
	int playerCount = MCC.GetOnlinePlayers().Length;
	MCC.LogToConsole("Player count: " + playerCount);
	Thread.Sleep(60000);
}