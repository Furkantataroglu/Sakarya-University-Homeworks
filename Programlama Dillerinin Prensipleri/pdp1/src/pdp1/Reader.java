/**
*
* @author Furkan Tataroğlu ve furkan.tataroglu@ogr.sakarya.edu.tr
* @since 15.04.2023
* <p>
* Bu sınıfta gelen dosya okunup ödevde istenilenler tek tek yapılmakta
* </p>
*/
package pdp1;
import java.io.*; 
import java.io.FileNotFoundException;
import java.util.Scanner; 
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.util.regex.*;
import java.util.*;
public class Reader {

	public static void main(String[] args) throws IOException {
		
	File javadoc = new File("javadoc.txt");
	javadoc.createNewFile();
	FileWriter fw = new FileWriter(javadoc);
	
	File teksatir = new File("teksatir.txt");
	teksatir.createNewFile();
	FileWriter teksatirwriter = new FileWriter(teksatir);
	
	File multiline = new File("coksatir.txt");
	multiline.createNewFile();
	FileWriter multiwriter = new FileWriter(multiline);
	
	
	List<String> javadoclist=new ArrayList<String>();
	List<String> teksatirlist=new ArrayList<String>();
	List<String> multilinelist=new ArrayList<String>();
		
		String functionName="";
		int count = 0;
		int countm= 0;
		int countj= 0;
		int curlybraceN=0;
		int sayac=0;
		int javadoccounter=0;
		boolean multifind=false;
		 try {
		      File myObj = new File(args[0]);
		      Scanner myReader = new Scanner(myObj);
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        Pattern javadocpattern = Pattern.compile("\\/\\*\\*(?!\\*)");
		        Pattern javadocpatternX= Pattern.compile("\\*\\/");
		        Matcher javadocmatcher = javadocpattern.matcher(data);
		        Matcher javadocmatcherX = javadocpatternX.matcher(data);
		        if(javadocmatcher.find())
		        {
		        	countj++;
		        	javadoccounter++;
		        }
		       
		        
		        if(javadoccounter!=0)
		        {
		        	javadoclist.add(data);
		        } 
		        if(javadocmatcherX.find())
		        {
		        	javadoccounter=0;
		        }
		        String classMatch = "(?<=class).*[^{]";
		        Pattern classPattern = Pattern.compile(classMatch);
		        Matcher classMatcher = classPattern.matcher(data);
		       
		        Pattern functionpattern = Pattern.compile("\\b\\w+\\s*\\([^)]*\\)\\s*\\{");
		        Matcher functionmatcher = functionpattern.matcher(data);
		        
		       
		        
		        //multiple lined comments		   
		        Pattern multilinepattern = Pattern.compile("\\/\\*(?!\\*)");
		        Matcher multilinematcher = multilinepattern.matcher(data);
		        
		        Pattern multilinepatternX = Pattern.compile("\\*\\/");
		        Matcher multilinematcherX = multilinepatternX.matcher(data);
		        if(multilinematcher.find()) {
		        	multifind=true;
		        	countm++;
		        }
		        if(multilinematcherX.find())
		        {
		        	multifind = false;
		        	multilinelist.add(data);
		        }
		        if(multifind==true)
		        {
		        	multilinelist.add(data);
		        }
		        //--------------------------------------------------------------------------------------------------//
		        //single lined comments
		        Pattern singlelinepattern = Pattern.compile("//.[a-zA-Z]");
		        Matcher singlelinematcher = singlelinepattern.matcher(data);
		        if (singlelinematcher.find()) {
		        	 
		             count++;
		             teksatirlist.add(data);
		        }
		       
		        
		        //-----------------------------------------------------------------------------------------------//
		        
		        String curlybrace = "\\{";

		        Pattern curlybracepattern = Pattern.compile(curlybrace);
		        Matcher curlybracematcher = curlybracepattern.matcher(data);
		        if(curlybracematcher.find())
		        {
		        	curlybraceN++;
		        }
		        
		        
		        String curlybrace1 = "\\}";

		        Pattern curlybracepattern1 = Pattern.compile(curlybrace1);
		        Matcher curlybracematcher1 = curlybracepattern1.matcher(data);
		        
		        if (functionmatcher.find())
		        {

		            String functionNameW = functionmatcher.group().trim().replaceAll("\\s*\\{", "");
		            functionName = functionNameW.substring(0, functionNameW.indexOf("("));
		        	
		        	  System.out.println("        Fonksiyon : " + functionName);
		        	  if(countj!=0)
		        	  {
		        	  fw.write("Fonksiyon: "+functionName+"\n");
		        	  }
		        	
		        }
		        
		        
		        
		        if(curlybracematcher1.find())
		        {
		        	curlybraceN--;
		        }
		        if(classMatcher.find())
		        {
		        	System.out.println("Sinif : " + classMatcher.group().toString());
		        	curlybraceN=0;
		        }
		        
		        if(curlybraceN==1 && sayac==0)
		        {
		        	sayac++;
		        }
		        if(curlybraceN==0 && sayac==1)
		        {
		        	sayac=0;
		        	System.out.print("            Tek Satir Yorum Sayisi :  "+count+"\n");
		        	System.out.print("            Cok Satirli Yorum Sayisi :"+countm+"\n");
		        	System.out.print("            JavaDoc Yorum Sayisi :    "+countj+"\n");
		        	System.out.print("---------------------------------------"+"\n");
		        	if(countj!=0)
		        	{
		        		for (String str : javadoclist) {
		        		    fw.write(str + System.lineSeparator());
		        		}
		        		
		        		fw.write("---------------------------"+"\n");
		        		
		        		javadoclist.clear();
		        	}
		        	if(count!=0)
		        	{
		        		 
			        	  teksatirwriter.write("Fonksiyon: "+functionName+"\n");
			        	  
		        		for (String str : teksatirlist) 
		        		{
		        		teksatirwriter.write(str + System.lineSeparator() );
		        		}
		        		teksatirwriter.write("---------------------------"+"\n");
		        		teksatirlist.clear();
		        	}
		        	if(countm!=0)
		        	{
		        		multiwriter.write("Fonksiyon: "+functionName+"\n");
		        		for (String str : multilinelist) 
		        		{
		        			multiwriter.write(str + System.lineSeparator());
		        		}
		        		multiwriter.write("---------------------------"+"\n");
		        		multilinelist.clear();
		        		
		        	}
		        	
		        	countj=0;
		        	countm=0;
		        	count=0;
		        }
		      }		        
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
		 fw.close();
		 teksatirwriter.close();	
		 multiwriter.close();
		 for(String list:javadoclist)
		 System.out.println(list);
	
	}

}
