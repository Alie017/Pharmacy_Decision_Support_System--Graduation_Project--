import { configureStore } from "@reduxjs/toolkit"
import themeReducer from './slices/themeReducer'

export const store = configureStore({
  reducer: {
    theme: themeReducer
  }
})