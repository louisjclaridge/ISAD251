<form method="POST">
        <input type="text" name="username" />
		<input type="password" name="password"/>
        <input type="submit" value="Enter"/>
</form>

<?php
    $username = $_POST["username"];
	$password = $_POST["password"];
	
	if($username == "admin" && $password == "letmein")
	{
		echo "Hello Admin";
	}
	else
	{
		echo "Why you no admin";
	}
	
?>

