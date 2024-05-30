<?php
header('Content-Type: application/json');

// Database connection
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "LibraryDB";

try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    echo json_encode(["message" => "Connection failed: " . $e->getMessage()]);
    exit();
}

// Get the request method and path
$method = $_SERVER['REQUEST_METHOD'];
$request = isset($_GET['request']) ? explode('/', trim($_GET['request'], '/')) : [];

if (count($request) < 1) {
    http_response_code(400);
    echo json_encode(["message" => "Bad Request"]);
    exit();
}

$resource = $request[0];
$id = isset($request[1]) ? $request[1] : null;

// Function to handle GET requests
function handleGetRequest($conn, $table)
{
    if ($table === 'Books') {
        $stmt = $conn->prepare("SELECT b.BookID, b.Title, b.ISBN, b.PublicationYear, p.PublisherName, c.CategoryName
                                FROM Books b
                                JOIN Publishers p ON b.PublisherID = p.PublisherID
                                JOIN Categories c ON b.CategoryID = c.CategoryID");
    } else {
        $stmt = $conn->prepare("SELECT * FROM $table");
    }

    $stmt->execute();
    $data = $stmt->fetchAll(PDO::FETCH_ASSOC);
    echo json_encode($data);
}

// Function to handle POST requests
function handlePostRequest($conn, $table, $data, $fields)
{
    $placeholders = implode(", ", array_fill(0, count($fields), "?"));
    $columns = implode(", ", $fields);
    $stmt = $conn->prepare("INSERT INTO $table ($columns) VALUES ($placeholders)");

    $values = [];
    foreach ($fields as $field) {
        $values[] = $data[$field];
    }

    if ($stmt->execute($values)) {
        echo json_encode(["message" => "Record added successfully"]);
    } else {
        echo json_encode(["message" => "Failed to add record"]);
    }
}

// Main API logic
switch ($resource) {
    case 'books':
        switch ($method) {
            case 'GET':
                handleGetRequest($conn, 'Books');
                break;
            case 'POST':
                $data = json_decode(file_get_contents('php://input'), true);
                handlePostRequest($conn, 'Books', $data, ['Title', 'ISBN', 'PublisherID', 'PublicationYear', 'CategoryID']);
                break;
            default:
                http_response_code(405);
                echo json_encode(["message" => "Method not allowed"]);
        }
        break;

    case 'authors':
        switch ($method) {
            case 'GET':
                handleGetRequest($conn, 'Authors');
                break;
            case 'POST':
                $data = json_decode(file_get_contents('php://input'), true);
                handlePostRequest($conn, 'Authors', $data, ['FirstName', 'LastName', 'BirthDate', 'Nationality']);
                break;
            default:
                http_response_code(405);
                echo json_encode(["message" => "Method not allowed"]);
        }
        break;

    case 'members':
        switch ($method) {
            case 'GET':
                handleGetRequest($conn, 'Members');
                break;
            case 'POST':
                $data = json_decode(file_get_contents('php://input'), true);
                handlePostRequest($conn, 'Members', $data, ['FirstName', 'LastName', 'Address', 'City', 'Country', 'Phone', 'Email']);
                break;
            default:
                http_response_code(405);
                echo json_encode(["message" => "Method not allowed"]);
        }
        break;

    case 'loans':
        switch ($method) {
            case 'GET':
                handleGetRequest($conn, 'Loans');
                break;
            case 'POST':
                $data = json_decode(file_get_contents('php://input'), true);
                handlePostRequest($conn, 'Loans', $data, ['BookID', 'MemberID', 'LoanDate', 'DueDate', 'ReturnDate']);
                break;
            default:
                http_response_code(405);
                echo json_encode(["message" => "Method not allowed"]);
        }
        break;

    case 'categories':
        switch ($method) {
            case 'GET':
                handleGetRequest($conn, 'Categories');
                break;
            case 'POST':
                $data = json_decode(file_get_contents('php://input'), true);
                handlePostRequest($conn, 'Categories', $data, ['CategoryName']);
                break;
            default:
                http_response_code(405);
                echo json_encode(["message" => "Method not allowed"]);
        }
        break;

    case 'publishers':
        switch ($method) {
            case 'GET':
                handleGetRequest($conn, 'Publishers');
                break;
            case 'POST':
                $data = json_decode(file_get_contents('php://input'), true);
                handlePostRequest($conn, 'Publishers', $data, ['PublisherName', 'Address', 'City', 'Country', 'Phone']);
                break;
            default:
                http_response_code(405);
                echo json_encode(["message" => "Method not allowed"]);
        }
        break;

    default:
        http_response_code(404);
        echo json_encode(["message" => "Endpoint not found"]);
        break;
}
