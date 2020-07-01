public class MailTool {
   public MailTool () {
   }
   public int retrieveMail() {

    System.out.println ("You've Got Mail");

         return 0;
   }
}


interface MailInterface {
   int getMail();
}


class MyMailTool implements MailInterface {
   private MailTool yourMailTool;
   public MyMailTool () {
    yourMailTool= new MailTool();
        setYourMailTool(yourMailTool);
   }
   public int getMail() {
      return getYourMailTool().retrieveMail();
   }
   public MailTool getYourMailTool() {
      return yourMailTool ;
   }
   public void setYourMailTool(MailTool newYourMailTool) {
      yourMailTool = newYourMailTool;
   }
}
 
public class Adapter
{
  public static void main(String[] args)
  {
    MyMailTool myMailTool = new MyMailTool();

    myMailTool.getMail();

  }
}
