class A{
	static void Main(){
		System.Console.WriteLine("HelloWorld!");
		System.Console.WriteLine("Using sum function from the namespace Abc:");
		Abc.B.sum(3,4);
	}	
}

//Main file to run
public class MainApplication {
    public static void main(String[] args) {
        // Creating instances of our classes
        Permission permission = new Permission();
        Role role = new Role();
        User user = new User();
        Leave leave = new Leave();
        Attendance attendance = new Attendance();
        Salary salary = new Salary();
        Employee employee = new Employee();
        Holiday holiday = new Holiday();

        // Call methods for each class
        permission.addPermission();
        role.addRole();
        user.addUser();
        leave.addLeave();
        attendance.addAttendance();
        salary.addSalary();
        employee.addEmployee();
        holiday.addHoliday();

        // Call edit, delete, and search methods for different classes
        role.editRole();
        user.editUser();
        leave.editLeave();
        attendance.editAttendance();
        salary.editSalary();
        employee.editEmployee();
        holiday.editHoliday();

        role.deleteRole();
        user.deleteUser();
        leave.deleteLeave();
        attendance.deleteAttendance();
        salary.deleteSalary();
        employee.deleteEmployee();
        holiday.deleteHoliday();

        role.searchRole();
        user.searchUser();
        leave.searchLeave();
        attendance.searchAttendance();
        salary.searchSalary();
        employee.searchEmployee();
        holiday.searchHoliday();

        // Assignment method for user class only as per the question
        user.assignUserPermission();
            }
}




//Permission class
import java.util.Scanner;

public class Permission {
    private int permissionId;
    private int permissionRoleId;
    private String permissionTitle;
    private String permissionModule;
    private String permissionDescription;

    private Scanner scanner = new Scanner(System.in);

    public void addPermission() {
        System.out.println("Enter permission ID:");
        permissionId = scanner.nextInt();
        
        System.out.println("Enter permission role ID:");
        permissionRoleId = scanner.nextInt();
        
        System.out.println("Enter permission title:");
        permissionTitle = scanner.next();
        
        System.out.println("Enter permission module:");
        permissionModule = scanner.next();
        
        System.out.println("Enter permission description:");
        permissionDescription = scanner.next();
        
        System.out.println("Permission added successfully!");
    }

    public void editPermission() {
        System.out.println("Enter permission ID to edit:");
        int idToEdit = scanner.nextInt();

        if (idToEdit == permissionId) {
            System.out.println("Enter new permission role ID:");
            permissionRoleId = scanner.nextInt();

            System.out.println("Enter new permission title:");
            permissionTitle = scanner.next();

            System.out.println("Enter new permission module:");
            permissionModule = scanner.next();

            System.out.println("Enter new permission description:");
            permissionDescription = scanner.next();

            System.out.println("Permission updated successfully!");
        } else {
            System.out.println("Permission with ID " + idToEdit + " not found.");
        }
    }

    public void deletePermission() {
        System.out.println("Enter permission ID to delete:");
        int idToDelete = scanner.nextInt();

        if (idToDelete == permissionId) {
            System.out.println("Permission deleted successfully!");
        } else {
            System.out.println("Permission with ID " + idToDelete + " not found.");
        }
    }

    public void searchPermission() {
        System.out.println("Enter permission ID to search:");
        int idToSearch = scanner.nextInt();

        if (idToSearch == permissionId) {
            System.out.println("Permission details:");
            System.out.println("Role ID: " + permissionRoleId);
            System.out.println("Title: " + permissionTitle);
            System.out.println("Module: " + permissionModule);
            System.out.println("Description: " + permissionDescription);
        } else {
            System.out.println("Permission with ID " + idToSearch + " not found.");
        }
    }
    public int getPermissionId() {
        return permissionId;
    }

    public void setPermissionId(int permissionId) {
        this.permissionId = permissionId;
    }
}


//Role class
import java.util.Scanner;

public class Role {
    private int roleId;
    private String roleTitle;
    private String roleDescription;

    private Scanner scanner = new Scanner(System.in);

    public void addRole() {
        System.out.println("Enter role ID:");
        roleId = scanner.nextInt();

        System.out.println("Enter role title:");
        roleTitle = scanner.next();

        System.out.println("Enter role description:");
        roleDescription = scanner.next();

        System.out.println("Role added successfully!");
    }

    public void editRole() {
        System.out.println("Enter role ID to edit:");
        int idToEdit = scanner.nextInt();

        if (idToEdit == roleId) {
            System.out.println("Enter new role title:");
            roleTitle = scanner.next();

            System.out.println("Enter new role description:");
            roleDescription = scanner.next();

            System.out.println("Role updated successfully!");
        } else {
            System.out.println("Role with ID " + idToEdit + " not found.");
        }
    }

    public void deleteRole() {
        System.out.println("Enter role ID to delete:");
        int idToDelete = scanner.nextInt();

        if (idToDelete == roleId) {
            roleId = 0;
            roleTitle = null;
            roleDescription = null;

            System.out.println("Role deleted successfully!");
        } else {
            System.out.println("Role with ID " + idToDelete + " not found.");
        }
    }

    public void searchRole() {
        System.out.println("Enter role ID to search:");
        int idToSearch = scanner.nextInt();

        if (idToSearch == roleId) {
            System.out.println("Role details:");
            System.out.println("Title: " + roleTitle);
            System.out.println("Description: " + roleDescription);
        } else {
            System.out.println("Role with ID " + idToSearch + " not found.");
        }
    }

    public void assignRole() {
        System.out.println("Enter user ID to assign role:");
        int userId = scanner.nextInt();
        System.out.println("Role assigned to user " + userId + " successfully!");
    }
}


// Salary class
import java.util.Scanner;

public class Salary {
    private int salaryId;
    private String salaryDescription;
    private String salaryType;
    private String salaryAmount;
    private String salaryTotal;
    private int salaryEmployeeId;
    private Permission relatedPermission; // Aggregation relationship

    private Scanner scanner = new Scanner(System.in);

    public void addSalary() {
        System.out.println("Enter salary ID:");
        salaryId = scanner.nextInt();

        System.out.println("Enter salary description:");
        salaryDescription = scanner.next();

        System.out.println("Enter salary type:");
        salaryType = scanner.next();

        System.out.println("Enter salary amount:");
        salaryAmount = scanner.next();

        System.out.println("Enter salary total:");
        salaryTotal = scanner.next();

        System.out.println("Enter employee ID:");
        salaryEmployeeId = scanner.nextInt();
        
        relatedPermission = new Permission();
        relatedPermission.setPermissionId(salaryId);

        System.out.println("Salary added successfully!");


    }
    public void editSalary() {
        System.out.println("Enter salary ID to edit:");
        int idToEdit = scanner.nextInt();
    
        if (idToEdit == salaryId) {
            System.out.println("Enter new salary description:");
            salaryDescription = scanner.next();
    
            System.out.println("Enter new salary type:");
            salaryType = scanner.next();
    
            System.out.println("Enter new salary amount:");
            salaryAmount = scanner.next();
    
            System.out.println("Enter new salary total:");
            salaryTotal = scanner.next();
    
            System.out.println("Enter new employee ID:");
            salaryEmployeeId = scanner.nextInt();
    
            if (relatedPermission != null) {
                relatedPermission.setPermissionId(salaryId);
            }
    
            System.out.println("Salary updated successfully!");
        } else {
            System.out.println("Salary with ID " + idToEdit + " not found.");
        }
    }
    public void deleteSalary() {
        System.out.println("Enter salary ID to delete:");
        int idToDelete = scanner.nextInt();

            if (idToDelete == salaryId) {
                salaryId = 0;
                salaryDescription = null;
                salaryType = null;
                salaryAmount = null;
                salaryTotal = null;
                salaryEmployeeId = 0;
    
                if (relatedPermission != null) {
                    relatedPermission.setPermissionId(0);
                }
    
               
            System.out.println("Salary deleted successfully!");
        } else {
            System.out.println("Salary with ID " + idToDelete + " not found.");
        }
    }
    public void searchSalary() {
        System.out.println("Enter salary ID to search:");
        int idToSearch = scanner.nextInt();
    
        if (idToSearch == salaryId) {
            System.out.println("Salary details:");
            System.out.println("Description: " + salaryDescription);
            System.out.println("Type: " + salaryType);
            System.out.println("Amount: " + salaryAmount);
            System.out.println("Total: " + salaryTotal);
            System.out.println("Employee ID: " + salaryEmployeeId);
        } else {
            System.out.println("Salary with ID " + idToSearch + " not found.");
        }
    }
    public void assignPermission(Permission permission) {
        relatedPermission = permission;
        System.out.println("Permission assigned to salary successfully!");
    }
}            


//User class
import java.util.Scanner;

public class User extends Permission {
    private int userId;
    private int userRoleId;
    private String userName;
    private String userEmail;
    private String userAddress;

    private Scanner scanner = new Scanner(System.in);

    public void addUser() {
        System.out.println("Enter user ID:");
        userId = scanner.nextInt();

        System.out.println("Enter user role ID:");
        userRoleId = scanner.nextInt();

        System.out.println("Enter user name:");
        userName = scanner.next();

        System.out.println("Enter user email:");
        userEmail = scanner.next();

        System.out.println("Enter user address:");
        userAddress = scanner.next();

        System.out.println("User added successfully!");
    }

    public void editUser() {
        System.out.println("Enter user ID to edit:");
        int idToEdit = scanner.nextInt();

        if (idToEdit == userId) {
            System.out.println("Enter new user role ID:");
            userRoleId = scanner.nextInt();

            System.out.println("Enter new user name:");
            userName = scanner.next();

            System.out.println("Enter new user email:");
            userEmail = scanner.next();

            System.out.println("Enter new user address:");
            userAddress = scanner.next();

            System.out.println("User updated successfully!");
        } else {
            System.out.println("User with ID " + idToEdit + " not found.");
        }
    }

    public void deleteUser() {
        System.out.println("Enter user ID to delete:");
        int idToDelete = scanner.nextInt();

        if (idToDelete == userId) {
            System.out.println("User deleted successfully!");
        } else {
            System.out.println("User with ID " + idToDelete + " not found.");
        }
    }

    public void searchUser() {
        System.out.println("Enter user ID to search:");
        int idToSearch = scanner.nextInt();

        if (idToSearch == userId) {
            System.out.println("User details:");
            System.out.println("Role ID: " + userRoleId);
            System.out.println("Name: " + userName);
            System.out.println("Email: " + userEmail);
            System.out.println("Address: " + userAddress);
        } else {
            System.out.println("User with ID " + idToSearch + " not found.");
        }
    }

    public void assignUserPermission() {
        System.out.println("Enter permission ID to assign to user:");
        int permissionId = scanner.nextInt();
        System.out.println("Permission assigned to user successfully!");
    }
}

// Attendance class
import java.util.Scanner;

public class Attendance {
    private int attendanceId;
    private int attendanceEmployeeId;
    private String attendanceType;
    private String attendanceDescription;
    private Permission relatedPermission; // Aggregation relationship

    private Scanner scanner = new Scanner(System.in);

    public void addAttendance() {
        System.out.println("Enter attendance ID:");
        attendanceId = scanner.nextInt();

        System.out.println("Enter employee ID:");
        attendanceEmployeeId = scanner.nextInt();

        System.out.println("Enter attendance type:");
        attendanceType = scanner.next();

        System.out.println("Enter attendance description:");
        attendanceDescription = scanner.next();
        relatedPermission = new Permission();
        relatedPermission.setPermissionId(attendanceId);
        
        System.out.println("Attendance added successfully!");
    }

    public void editAttendance() {
        System.out.println("Enter attendance ID to edit:");
        int idToEdit = scanner.nextInt();

        if (idToEdit == attendanceId) {
            System.out.println("Enter new employee ID:");
            attendanceEmployeeId = scanner.nextInt();

            System.out.println("Enter new attendance type:");
            attendanceType = scanner.next();

            System.out.println("Enter new attendance description:");
            attendanceDescription = scanner.next();

            System.out.println("Attendance updated successfully!");
        } else {
            System.out.println("Attendance with ID " + idToEdit + " not found.");
        }
    }

    public void deleteAttendance() {
        System.out.println("Enter attendance ID to delete:");
        int idToDelete = scanner.nextInt();

        if (idToDelete == attendanceId) {
            attendanceId = 0;
            attendanceEmployeeId = 0;
            attendanceType = null;
            attendanceDescription = null;

            System.out.println("Attendance deleted successfully!");
        
        } else {
            System.out.println("Attendance with ID " + idToDelete + " not found.");
        }
    }

    public void searchAttendance() {
        System.out.println("Enter attendance ID to search:");
        int idToSearch = scanner.nextInt();

        if (idToSearch == attendanceId) {
            System.out.println("Attendance details:");
            System.out.println("Employee ID: " + attendanceEmployeeId);
            System.out.println("Type: " + attendanceType);
            System.out.println("Description: " + attendanceDescription);
        } else {
            System.out.println("Attendance with ID " + idToSearch + " not found.");
        }
    }
}

// Employee class
import java.util.Scanner;

public class Employee {
    private int employeeId;
    private String employeeName;
    private String employeeMobile;
    private String employeeEmail;
    private String employeeAddress;
    private String employeeUsername;
    private String employeePassword;
    private Permission relatedPermission; // Aggregation relationship

    private Scanner scanner = new Scanner(System.in);

    public void addEmployee() {
        System.out.println("Enter employee ID:");
        employeeId = scanner.nextInt();

        System.out.println("Enter employee name:");
        employeeName = scanner.next();

        System.out.println("Enter employee mobile:");
        employeeMobile = scanner.next();

        System.out.println("Enter employee email:");
        employeeEmail = scanner.next();

        System.out.println("Enter employee address:");
        employeeAddress = scanner.next();

        System.out.println("Enter employee username:");
        employeeUsername = scanner.next();

        System.out.println("Enter employee password:");
        employeePassword = scanner.next();
        relatedPermission = new Permission();
        relatedPermission.setPermissionId(employeeId);

        System.out.println("Employee added successfully!");
    }
    public void editEmployee() {
        System.out.println("Enter employee ID to edit:");
        int idToEdit = scanner.nextInt();
    
        // Checking if the entered ID matches the current employee's ID
        if (idToEdit == employeeId) {
            // Prompt the user to update employee details
            System.out.println("Enter new employee name:");
            employeeName = scanner.next();
    
            System.out.println("Enter new employee mobile:");
            employeeMobile = scanner.next();
    
            System.out.println("Enter new employee email:");
            employeeEmail = scanner.next();
    
            System.out.println("Enter new employee address:");
            employeeAddress = scanner.next();
    
            System.out.println("Enter new employee username:");
            employeeUsername = scanner.next();
    
            System.out.println("Enter new employee password:");
            employeePassword = scanner.next();
    
            System.out.println("Employee updated successfully!");
        } else {
            System.out.println("Employee with ID " + idToEdit + " not found.");
        }
    }
    public void deleteEmployee() {
        System.out.println("Enter employee ID to delete:");
        int idToDelete = scanner.nextInt();
    
        // Checking if the entered ID matches the current employee's ID
        if (idToDelete == employeeId) {
            // Delete logic (not implemented in this example)
             employeeId = 0;
             employeeName = null;
             employeeMobile = null;
             employeeEmail = null;
             employeeAddress = null;
             employeeUsername = null;
             employeePassword = null;
            System.out.println("Employee deleted successfully!");
        } else {
            System.out.println("Employee with ID " + idToDelete + " not found.");
        }
    }
    public void searchEmployee() {
        System.out.println("Enter employee ID to search:");
        int idToSearch = scanner.nextInt();
    
        // Check if the entered ID matches the current employee's ID
        if (idToSearch == employeeId) {
            // Display employee details
            System.out.println("Employee details:");
            System.out.println("Name: " + employeeName);
            System.out.println("Mobile: " + employeeMobile);
            System.out.println("Email: " + employeeEmail);
            System.out.println("Address: " + employeeAddress);
            System.out.println("Username: " + employeeUsername);
            System.out.println("Password: " + employeePassword);
        } else {
            System.out.println("Employee with ID " + idToSearch + " not found.");
        }
    }
}    



// Holiday class
import java.util.Scanner;

public class Holiday {
    private int holidayId;
    private int holidayEmployeeId;
    private String holidayDuration;
    private String holidayDescription;
    private String holidayDate;
    private Permission relatedPermission; // Aggregation relationship
    private Scanner scanner = new Scanner(System.in);

    public void addHoliday() {
        System.out.println("Enter holiday ID:");
        holidayId = scanner.nextInt();

        System.out.println("Enter employee ID:");
        holidayEmployeeId = scanner.nextInt();

        System.out.println("Enter holiday duration:");
        holidayDuration = scanner.next();

        System.out.println("Enter holiday description:");
        holidayDescription = scanner.next();

        System.out.println("Enter holiday date:");
        holidayDate = scanner.next();
        relatedPermission = new Permission();
        relatedPermission.setPermissionId(holidayId);

        System.out.println("Holiday added successfully!");
    }

    public void editHoliday() {
        System.out.println("Enter holiday ID to edit:");
        int idToEdit = scanner.nextInt();

        if (idToEdit == holidayId) {
            System.out.println("Enter new employee ID:");
            holidayEmployeeId = scanner.nextInt();

            System.out.println("Enter new holiday duration:");
            holidayDuration = scanner.next();

            System.out.println("Enter new holiday description:");
            holidayDescription = scanner.next();

            System.out.println("Enter new holiday date:");
            holidayDate = scanner.next();

            System.out.println("Holiday updated successfully!");
        } else {
            System.out.println("Holiday with ID " + idToEdit + " not found.");
        }
    }

    public void deleteHoliday() {
        System.out.println("Enter holiday ID to delete:");
        int idToDelete = scanner.nextInt();

        if (idToDelete == holidayId) {
            System.out.println("Enter new employee ID:");
            holidayEmployeeId = scanner.nextInt();

            System.out.println("Enter new holiday duration:");
            holidayDuration = scanner.next();

            System.out.println("Enter new holiday description:");
            holidayDescription = scanner.next();

            System.out.println("Enter new holiday date:");
            holidayDate = scanner.next();

            System.out.println("Holiday updated successfully!");
            System.out.println("Holiday deleted successfully!");
        } else {
            System.out.println("Holiday with ID " + idToDelete + " not found.");
        }
    }

    public void searchHoliday() {
        System.out.println("Enter holiday ID to search:");
        int idToSearch = scanner.nextInt();

        if (idToSearch == holidayId) {
            System.out.println("Holiday details:");
            System.out.println("Employee ID: " + holidayEmployeeId);
            System.out.println("Duration: " + holidayDuration);
            System.out.println("Description: " + holidayDescription);
            System.out.println("Date: " + holidayDate);
        } else {
            System.out.println("Holiday with ID " + idToSearch + " not found.");
        }
    }
}

// Leave class
import java.util.Scanner;

public class Leave {
    private int leaveId;
    private String leaveType;
    private String leaveDescription;
    private String leaveStatus;
    private String leaveTo;
    private String leaveFrom;
    private String leaveEmployee;
    private Permission relatedPermission; // Aggregation relationship

    private Scanner scanner = new Scanner(System.in);

    public void addLeave() {
        System.out.println("Enter leave ID:");
        leaveId = scanner.nextInt();

        System.out.println("Enter leave type:");
        leaveType = scanner.next();

        System.out.println("Enter leave description:");
        leaveDescription = scanner.next();

        System.out.println("Enter leave status:");
        leaveStatus = scanner.next();

        System.out.println("Enter leave to date:");
        leaveTo = scanner.next();

        System.out.println("Enter leave from date:");
        leaveFrom = scanner.next();

        System.out.println("Enter employee ID:");
        leaveEmployee = scanner.next();
        relatedPermission = new Permission();
        relatedPermission.setPermissionId(leaveId);

        System.out.println("Leave added successfully!");
    }

    public void editLeave() {
        System.out.println("Enter leave ID to edit:");
        int idToEdit = scanner.nextInt();

        if (idToEdit == leaveId) {
            System.out.println("Enter new leave type:");
            leaveType = scanner.next();

            System.out.println("Enter new leave description:");
            leaveDescription = scanner.next();

            System.out.println("Enter new leave status:");
            leaveStatus = scanner.next();

            System.out.println("Enter new leave to date:");
            leaveTo = scanner.next();

            System.out.println("Enter new leave from date:");
            leaveFrom = scanner.next();

            System.out.println("Enter new employee ID:");
            leaveEmployee = scanner.next();

            if (relatedPermission != null) {
                relatedPermission.setPermissionId(leaveId);
            }

            System.out.println("Leave updated successfully!");
        } else {
            System.out.println("Leave with ID " + idToEdit + " not found.");
        }
    }

    public void deleteLeave() {
        System.out.println("Enter leave ID to delete:");
        int idToDelete = scanner.nextInt();

        if (idToDelete == leaveId) {
            
            leaveId = 0;
            leaveType = null;
            leaveDescription = null;
            leaveStatus = null;
            leaveTo = null;
            leaveFrom = null;
            leaveEmployee = null;

            System.out.println("Leave deleted successfully!");
        } else {
            System.out.println("Leave with ID " + idToDelete + " not found.");
        }
    }

    public void searchLeave() {
        System.out.println("Enter leave ID to search:");
        int idToSearch = scanner.nextInt();

        if (idToSearch == leaveId) {
            System.out.println("Leave details:");
            System.out.println("Type: " + leaveType);
            System.out.println("Description: " + leaveDescription);
            System.out.println("Status: " + leaveStatus);
            System.out.println("To Date: " + leaveTo);
            System.out.println("From Date: " + leaveFrom);
            System.out.println("Employee ID: " + leaveEmployee);
        } else {
            System.out.println("Leave with ID " + idToSearch + " not found.");
        }
    }
}


