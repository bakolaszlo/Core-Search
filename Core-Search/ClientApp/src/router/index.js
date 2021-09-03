import { createRouter, createWebHistory } from 'vue-router'
import Search from '../components/Search.vue'

const routes = [
  {
    path: '/search',
    name: 'Search',
    component: Search
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
