<template>
  <div>
    <div v-for="item in items" :key="item.id">
      {{ item.name }}
    </div>
    <form>
      <label for="fname">Name</label><br />
      <input type="text" v-model="book.name" /><br />
      <label for="lname">Stock</label><br />
      <input type="number" v-model="book.stock" /><br /><br />
      <label for="lname">Price</label><br />
      <input type="number" v-model="book.price" /><br /><br />
      <label for="lname">CategoryId</label><br />
      <input type="number" v-model="book.categoryId" /><br /><br />
    </form>
    <button @click="addBook">Ekle</button>
    <div v-if="success"><p>ekleme işlemi başarılı!</p></div>
    <div v-else-if="!success">
      <li v-for="message in messages" :key="message">
        {{ message }}
      </li>
    </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  name: "HelloWorld",
  data() {
    return {
      items: [],
      book: {
        name: null,
        stock: 0,
        price: 0,
        categoryId: 0,
      },
      success: false,
      messages: [],
    };
  },
  created() {
    axios.get("https://localhost:7143/api/Products").then((res) => {
      this.items = res.data.data;
    });
  },
  methods: {
    addBook() {
      axios
        .post("https://localhost:7143/api/Products", this.book)
        .then((res) => {
          if (res.status == 201) {
            this.success = true;
          }
        })
        .catch((error) => {
          this.messages = error.response.data.errors;
          this.success = false;
        });
    },
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped></style>
