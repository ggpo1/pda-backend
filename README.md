# PDA - API Service

### List all users

**Definition**

`GET /api/users`

**Response**

- `200 OK` on success

```json
[
    {
        "user_id": "1",
        "username": "sasha123",
        "password": "818ba9c12d75dc18f76a959fe011b534",
        "email": "sasha123@gmail.com"    
    },
    {
        "user_id": "2",
        "username": "roman1999",
        "password": "5df7731bf4fbc21e7d3967a7a159d8f5",
        "email": "roman1999@gmail.com"
    }
]
```

### Browse user by id

**Definition**

`GET /api/users/<user_id>`

**Response**

- `200 OK` on success

```json
{
    "user_id": "1",
    "username": "sasha123",
    "password": "818ba9c12d75dc18f76a959fe011b534",
    "email": "sasha123@gmail.com"
}
```

### Registering a new device

**Definition**

`POST /devices`

**Arguments**

- `"identifier":string` a globally unique identifier for this device
- `"name":string` a friendly name for this device
- `"device_type":string` the type of the device as understood by the client
- `"controller_gateway":string` the IP address of the device's controller

If a device with the given identifier already exists, the existing device will be overwritten.

**Response**

- `201 Created` on success

```json
{
    "identifier": "floor-lamp",
    "name": "Floor Lamp",
    "device_type": "switch",
    "controller_gateway": "192.1.68.0.2"
}
```

## Lookup device details

`GET /device/<identifier>`

**Response**

- `404 Not Found` if the device does not exist
- `200 OK` on success

```json
{
    "identifier": "floor-lamp",
    "name": "Floor Lamp",
    "device_type": "switch",
    "controller_gateway": "192.1.68.0.2"
}
```

## Delete a device

**Definition**

`DELETE /devices/<identifier>`

**Response**

- `404 Not Found` if the device does not exist
- `204 No Content` on success
