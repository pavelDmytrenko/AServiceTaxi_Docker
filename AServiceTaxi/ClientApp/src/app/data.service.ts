import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Car } from './car';
import { Order } from './order';

@Injectable()
export class DataService {

    private urlcar = "/api/cars";
    private urlorder = "/api/orders";

    constructor(private http: HttpClient) {
    }

    getCars() {
        return this.http.get(this.urlcar);
    }

    getCar(id: number) {
        return this.http.get(this.urlcar + '/' + id);
    }

    getOrders() {
        return this.http.get(this.urlorder);
    }

    getOrder(id: number) {
        return this.http.get(this.urlorder + '/' + id);
    }

    createCar(car: Car) {
        return this.http.post(this.urlcar, car);
    }
    createOrder(order: Order) {
        return this.http.post(this.urlorder, order);
    }
    updateCar(car: Car) {

        return this.http.post(this.urlcar, car);
    }
    updateOrder(order: Order) {

        return this.http.post(this.urlorder, order);
    }
    deleteCar(id: number) {
        return this.http.delete(this.urlcar + '/' + id);
    }
    deleteOrder(id: number) {
        return this.http.delete(this.urlorder + '/' + id);
    }
}