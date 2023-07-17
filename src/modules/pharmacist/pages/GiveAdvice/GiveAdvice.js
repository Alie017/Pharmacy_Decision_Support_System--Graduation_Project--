import React from 'react'
import { useNavigate } from 'react-router-dom'
import { useMutation } from 'react-query'
import { useFormik } from 'formik'
import Layout from '../../layouts/Layout'
import styles from './GiveAdvice.module.css'
import { createAdvice } from '../../../../services/adviceService'
import { toast } from 'react-toastify'
import { useSelector } from 'react-redux'

export default function GiveAdvice() {
	const navigate = useNavigate()

	const { theme } = useSelector(state => state.theme)

	const createAdviceMutation = useMutation({
		mutationFn: createAdvice,
		onSuccess: () => {
			navigate('/pharmacist')
			toast.success('Advice created successfully', {theme})
		},
	})

	const formik = useFormik({
		initialValues: {
			userId: localStorage.getItem('userId'),
			description: '',
		},
		onSubmit: values => {
			createAdviceMutation.mutate(values)
		},
	})

	return (
		<Layout>
			<h3 className='section-title'>Give Advice</h3>
			<span className='line'></span>
			<form onSubmit={formik.handleSubmit} className={styles.form}>
				<div className={styles.formGroup}>
					<label htmlFor='description'>Description</label>
					<textarea
						name='description'
						rows='5'
						onChange={formik.handleChange}
						value={formik.values.description}
						required
					></textarea>
				</div>
				<div className={styles.formGroup}>
					<button>Create Advice</button>
				</div>
			</form>
		</Layout>
	)
}
