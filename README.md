## Base URL

The base URL for all endpoints is:http://localhost:5000/api/car

### 1. **Create a Car**

- **Endpoint**: `/api/car`
- **Method**: `POST`
- **Request Body**:
  ```json
  {
    "make": "Toyota",
    "model": "Corolla",
    "year": 2020
  }
  Response:
201 Created

### 2. **Get all Cars**

- **Endpoint**: `/api/car`
- **Method**: `GET`

  Response:
200 OK
### 3. **Get Cars by id**

- **Endpoint**: `/api/car/1`
- **Method**: `GET`

  Response:
  200 OK
  ### 4. **Update a Car**

- **Endpoint**: `/api/car/1`
- **Method**: `Put`
- **Request Body**:
  ```json
  {
    "make": "Toyota",
    "model": "Corolla",
    "year": 2020
  }
  Response:
  204 No Content
  
### 3. **Delete a Car **

- **Endpoint**: `/api/car/1`
- **Method**: `Delete`

  Response:
   204 No Content
