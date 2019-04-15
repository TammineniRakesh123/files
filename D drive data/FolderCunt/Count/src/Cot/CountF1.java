package Cot;

import java.io.File;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class CountF1 
{
	static int count = 0;
	public static void main(String[] args)
	{
		
		int count1=getFile("\"d:\"");
		System.out.println(count1);
	}
	private static int getFile(String dirPath) {
	    File f = new File(dirPath);
	    File[] files = f.listFiles();

	    if (files != null)
	    for (int i = 0; i < files.length; i++) {
	        count++;
	        File file = files[i];

	        if (file.isDirectory()) {   
	             getFile(file.getAbsolutePath()); 
	        }
	    }
		return count;
	}
}
