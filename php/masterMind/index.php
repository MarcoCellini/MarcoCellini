<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>master-mind</title>

    <style>
        .row {
            display: grid;
            grid-template-columns: repeat(5, 1fr);
            width: 128px;
            padding: 10px;
        }

        form {
            padding: 10px;
        }

        .cell {
            width: 32px;
            height: 32px;
            border: 1px solid black;
        }

        .feedback {
            width: 32px;
            height: 32px;
            margin-left: 20px;
            display: grid;
            grid-template-columns: 1fr 1fr;
        }

        .pin {
            border: 1px solid black;
            border-radius: 100%;
        }

        select {
            width: 32px;
            height: 32px;
        }
    </style>

    <script>
        let colors = ['red', 'green', 'blue', 'purple', 'yellow', 'orange', 'gray', 'black'];

        const upt_color = (id) => {
            let index_color = document.querySelector('#' + id);
            let color = colors[index_color.value];
            document.getElementById(id).style.backgroundColor = color;
        };
    </script>
</head>

<?php
session_start();

$colors = ['red', 'green', 'blue', 'purple', 'yellow', 'orange', 'gray', 'black'];

if (isset($_POST['clear'])) {
    $_SESSION['grid'] = "";
    $_SESSION['attemps'] = 0;
}

for ($i = 0; $i < 4; $i++)
    $try .= $_POST[$i];

if (strlen($try) == 4 && $_SESSION['attemps'] < 10) {
    $_SESSION['attemps']++;
    $_SESSION['grid'] = '
    <div class="row">
        <div class="cell" style="background-color:'.$colors[$try[0]].'"></div>
        <div class="cell" style="background-color:'.$colors[$try[1]].'"></div>
        <div class="cell" style="background-color:'.$colors[$try[2]].'"></div>
        <div class="cell" style="background-color:'.$colors[$try[3]].'"></div>
        <div class="feedback">
            <div class="pin"></div>
            <div class="pin"></div>
            <div class="pin"></div>
            <div class="pin"></div>
        </div>
    </div>'.$_SESSION['grid'];
}

$value = "red";

?>

<body>

    <div class="grid">
        <?php
        echo $_SESSION['grid'];
        ?>
    </div>

    <form method="post">
        <?php
        for ($i = 0; $i < 4; $i++)
            echo '
            <select name="' . $i . '" id="color' . $i . '" onchange="upt_color(`color' . $i . '`)">
                <option></option>
                <option value="0" style="background-color: red"></option>
                <option value="1" style="background-color: green"></option>
                <option value="2" style="background-color: blue"></option>
                <option value="3" style="background-color: purple"></option>
                <option value="4" style="background-color: yellow"></option>
                <option value="5" style="background-color: orange"></option>
                <option value="6" style="background-color: gray"></option>
                <option value="7" style="background-color: black"></option>
            </select>'
                ?>
            <input type="submit" value="Check">
    </form>
    <form method="post">
        <input type="submit" name="clear" value="New Game">
    </form>
</body>

</html>