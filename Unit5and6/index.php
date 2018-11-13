<!DOCTYPE html>
<?php
    require 'functions.php';
    if(isset($_POST['table']))
    {
        $tableName = $_POST['table'];
    }
?>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <select name="table" id="ddTable">
            <option value="customers">Customers</option>
            <option value="Orders">Orders</option>
            <option value="Order-Lines">Order Lines</option>
        </select>
        
        <h1>CREATE</h1>
        <p>
            
        </p>
        
        <h1>READ</h1>
        <p>
            <?php
                        $results = getAll('customers');
							foreach($results as $row)
							{
								echo $row['customer_numb']."<br>";
								echo $row['customer_first_name']."<br>";
								echo $row['customer_last_name']."<br>";
								echo $row['customer_street']."<br>";
								echo $row['customer_city']."<br>";
								echo $row['customer_state']."<br>";
								echo $row['customer_zip']."<br>";
								echo $row['customer_phone']."<br>";
								echo $row['customer_email']."<br>";
								echo '<br>';
							}
						//echo $results;
            ?>
        </p>
        <h1>UPDATE</h1>
        
        <h1>DELETE</h1>
        
    </body>
</html>
