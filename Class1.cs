using System;

public class Test
{
	public int Mid;
	public int Final;

	public void SetFinal(int value)
	{
		Final = value;
	}

	public int GetFinal()
	{
        return Final;
    }

	public double GetAvg()
	{
		return (Mid + Final)/2.0;
	}

	public void SetGrate(int m,int f)
	{
		if (ValidGrade(m, f))
		{
			Mid = m;
			Final = f;
		}
	} 

	private bool ValidGrade(int m,int f)
	{
		if (m >= 0 && m <= 100)
		{
			if (f >= 0 && f <= 100)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			return false;
		}
	}


	
}
