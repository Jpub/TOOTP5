import java.util.Date;

public class Employee extends Person{

        private String CompanyID;
        private String Title;
        private Date StartDate;

        private Spouse spouse;
        private Child[] child;
        private Division division;
        private JobDescription[] jobDescriptions;

        public String getCompanyID() {return CompanyID;}
        public String getTitle() {return Title;}
        public Date getStartDate() {return StartDate;}

        public void setCompanyID(String CompanyID) {}
        public void setTitle(String Title) {}
        public void setStartDate(int StartDate) {}

}
