import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Car } from './car';
import { Order } from './order';

@Injectable({
    providedIn: 'root'
  })
export class DataService {

    private urlcar = "/api/cars";
    private urlorder = "/api/orders";

    constructor(private http: HttpClient) {
    }

    getCars(): Observable<Car[]> {
        return this.http.get<Car[]>(this.urlcar)
    }

    getCar(id: number): Observable<Car> {
        return this.http.get<Car>(this.urlcar + '/' + id);
    }

    getOrders(): Observable<Order[]> {
        return this.http.get<Order[]>(this.urlorder);
    }

    getOrder(id: number): Observable<Order> {
        return this.http.get<Order>(this.urlorder + '/' + id);
    }

    createCar(car: Car) {
        return this.http.post(this.urlcar, car);
    }
    createOrder(order: Order) {
        return this.http.post(this.urlorder, order);
    }
    updateCar(car: Car) {

        return this.http.put(this.urlcar, car);
    }
    updateOrder(order: Order) {

        return this.http.put(this.urlorder, order);
    }
    deleteCar(id: number) {
        return this.http.delete(this.urlcar + '/' + id);
    }
    deleteOrder(id: number) {
        return this.http.delete(this.urlorder + '/' + id);
    }
}