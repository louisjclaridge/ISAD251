<?php
/**
 * Created by PhpStorm.
 * User: s1atkinson
 * Date: 10/11/2016
 * Time: 20:25
 */

    
$tableName = $_GET['tablename'];
$id = $_GET['id'];
$idColumn = $_GET['idColumn'];

if(isset($tableName))
{
    $results = getAll($tableName);
    if($results)
    {
        //Hopefully if the results have been the right PDO type we should be able
        //to extract the column names with ease.
        $columns = empty($results) ? array() : array_keys($results[0]);
    }
}

if(isset($_POST['Submit']))
{
    $values = array();
    $idValues = array($idColumn => $id);
    foreach($_POST as $key => $value)
    {
        if(!empty($value) && ($value != "Submit"))
        {
            $values[$key] = $value;
        }
    }
    $result = update($idValues, $values, $tableName);
}


?>
<html>
<head>
    <meta charset="UTF-8">
    <title></title>
</head>
<body>
<form action="<?php echo $_SERVER['PHP_SELF'].'?'.http_build_query($_GET); ?>" method="post">
    <h1>Edit Table</h1>
    <p>Please only enter data into the columns that require to be changed. Those left blank will
        not be updated.
    <p>
        <?php
        $tableString = '<table border="1"><tr>';
        $inputString = '';

        foreach($columns as $column)
        {
            if($column != $idColumn)
            {
                $tableString .= '<th>'.$column.'</th>';
                $inputString .= '<td><input type=\'text\' name=\''.$column.'\'/></td>';
            }
        }
        $tableString .='</tr><tr>'.$inputString.'</tr></table>';

        echo $tableString;

        if(isset($_POST['Submit']))
        {
            if($result>0)
            {
                echo 'Edit has been successful.  Return to index page';
            }
            else
            {
                echo 'Edit has not been successful.';
            }
        }
        ?>
    </p>

    <input type="submit" value="Submit" name="Submit">
</form>

</html>

