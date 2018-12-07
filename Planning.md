# Planning Document

## CREATE DATABASE vinter
## CREATE TABLE `vinter`.`varietals` ( `id` INT NOT NULL AUTO_INCREMENT , `name` VARCHAR(255) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;

## CREATE TABLE `vinter`.`bottles` ( `id` INT NOT NULL AUTO_INCREMENT , `name` VARCHAR(255) NOT NULL , `region` VARCHAR(255) NOT NULL , `maker` VARCHAR(255) NOT NULL , `varietal_id` INT(255) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;

* Outline Classes/Tables
* Outline Models/Methods
* Create Database/tables
* Create Test Database
* Export Database
* Add Exported Database to Vinter.Solution folder
* Create Models folder
* Create .cs file for each Class in Models folder
* Create ControllerTest file for each Class and Home
* Create ModelTests folder
* Create Test Files for each Class in the ModelTests folder
* Create basic content for all files
* Set up test files for working with the database
* Test that class properties can be retrieved
* Implement teardown using Dispose() and ClearAll() so that test data is cleared between each test
* Add Equals() method to type cast objects, "bottles" in this case, that are in different parts of memory - one in RAM, one from the database - as the same object.
* Test that Save() saves to Database & GetAll() gets all bottles.

### Classes
* Bottle
* Varietal

### Varietal Columns/Properties
* ID
* Name

### Bottle Columns/Properties
* ID
* Name
* Region
* Maker
* Varietal ID

### Varietal Model
<!-- * public int GetId() -->
* public string GetName()
* public void Add()
* public void Delete()
* public List<Varietal> GetAll()
* public void Save()


### Bottle Model
<!-- * public int GetId() -->
* public string GetName()
* public void Add()
* public void Delete()
* public List<Bottle> GetAll()
* public void Save()

###  Specs
#### Bottle Model Specs
##### Spec 0: Bottle returns bottle
**Example:**
Input:  'Zinfandel', "Mexico", "Don Giovanni", 1, 1
Output: Bottle
##### Spec: Bottle returns bottle id
**Example:**
Input:  'Zinfandel', "Mexico", "Don Giovanni", 1, 1
Output: 1
##### Spec: Bottle returns bottle name
**Example:**
Input:  'Zinfandel', "Mexico", "Don Giovanni", 1, 1
Output: 'Zinfandel'
##### Spec: Bottle returns bottle region
**Example:**
Input:  'Zinfandel', "Mexico", "Don Giovanni", 1, 1
Output: "Mexico"
##### Spec: Bottle returns bottle maker
**Example:**
Input:  'Zinfandel', "Mexico", "Don Giovanni", 1, 1
Output: "Don Giovanni"
##### Spec: Bottle returns varietal id
**Example:**
Input:  'Zinfandel', "Mexico", "Don Giovanni", 1, 1
Output: 1
##### Spec: Bottle returns empty list
**Example:**
Input:
bottleOne: ('Zinfandel', "Mexico", "Don Giovanni", 1, 1), bottleTwo: ('PortoPort', "California", "Paul's Vineyard", 2, 1)
Output: List<Bottle>{}
### Spec: Test that ClearAll() clears database
**Example:**
Input:
bottleOne: ('Zinfandel', "Mexico", "Don Giovanni", 1, 1), bottleTwo: ('PortoPort', "California", "Paul's Vineyard", 2, 1)
Output: List<Bottle>{}
### Spec: Test that Save() saves to database
**Example:**
Input:
bottleOne: ('Zinfandel', "Mexico", "Don Giovanni", 1, 1), bottleTwo: ('PortoPort', "California", "Paul's Vineyard", 2, 1)
Output: List<Bottle>{bottleOne, bottleTwo}
##### Spec: Bottle returns a list of all bottles
**Example:**
Input:
bottleOne: ('Zinfandel', "Mexico", "Don Giovanni", 1, 1), bottleTwo: ('PortoPort', "California", "Paul's Vineyard", 2, 1)
Output: List<Bottle>{bottleOne, bottleTwo}

##### Spec: Bottle add new bottle
**Example:**
Input: 'New Item: Cabernet'
Output: 'Cabernet'
******NOT TESTED *** TO BE CONTINUED***
##### Spec: Bottle delete from list array of things(Cabernet)
**Example:**
Input: 'Zinfandel' 'Cabernet'
Output: 'Cabernet'
##### Spec: Bottle saves item (new item)
**Example:**
Input:  'New Item: Cabernet'
Output: 'Cabernet'

#### Varietal Model Specs
##### Spec 1: VarietalConstructor returns Varietal
**Example:**
Input: "test varietal", 2.
Output: Varietal

##### Spec 2: Varietal returns name (GetName_ReturnsName_String())
**Example:**
Input: "test varietal", 2
Output: "test varietal"
##### Spec 3: Varietal return id (GetId_ReturnsVarietalId_Int())
**Example:**
Input: 2
Output: 2
##### Spec 4: Varietal add new item
**Example:**
Input: 'New Item: Cabernet'
Output: 'Cabernet'
##### Spec 3: Varietal delete from list array of things(Cabernet)
**Example:**
Input: 'Zinfandel' 'Cabernet'
Output: 'Cabernet'
##### Spec 4: Varietal returns a list of all varieties
**Example:**
Input: Method call
Output: 'Zinfandel' 'Cabernet'
##### Spec 5: Varietal saves item (new item)
**Example:**
Input:  'New Item: Cabernet'
Output: 'Cabernet'
