## Planning Document

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
#### Varietal Model Specs
##### Spec 1: Varietal returns name
**Example:**
Input: 'Zinfandel'.
Output: 'Zinfandel'
##### Spec 2: Varietal add new item
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


#### Bottle Model Specs
##### Spec 1: Bottle returns name
**Example:**
Input: 'Zinfandel'.
Output: 'Zinfandel'
##### Spec 2: Bottle add new item
**Example:**
Input: 'New Item: Cabernet'
Output: 'Cabernet'
##### Spec 3: Bottle delete from list array of things(Cabernet)
**Example:**
Input: 'Zinfandel' 'Cabernet'
Output: 'Cabernet'
##### Spec 4: Bottle returns a list of all bottles
**Example:**
Input: Method call
Output: 'Zinfandel' 'Cabernet'
##### Spec 5: Bottle saves item (new item)
**Example:**
Input:  'New Item: Cabernet'
Output: 'Cabernet'



## CREATE TABLE `vinter`.`varietals` ( `id` INT NOT NULL AUTO_INCREMENT , `name` VARCHAR(255) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;

##CREATE TABLE `vinter`.`bottles` ( `id` INT NOT NULL AUTO_INCREMENT , `name` VARCHAR(255) NOT NULL , `region` VARCHAR(255) NOT NULL , `maker` VARCHAR(255) NOT NULL , `varietal_id` INT(255) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;
